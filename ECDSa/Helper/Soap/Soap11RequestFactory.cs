using ECDSa.Helper.Soap._1_1;
using ECDSa.Helper.Soap.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;

namespace ECDSa.Helper.Soap
{
    public sealed class Soap11RequestFactory : ISoapRequestFactory
    {
        public HttpRequestMessage CreateSoapRequest(SoapOptions o)
        {
            var soapEnvelope = o.SignEnvelope ? CreateSignedEnvelope(o) : CreateEnvelope(o);

            var request = new HttpRequestMessage(HttpMethod.Post, o.Uri)
            {
                Content = new StringContent(soapEnvelope, Encoding.UTF8)
            };
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("text/xml")
            {
                CharSet = Encoding.UTF8.WebName
            };
            request.Headers.Add("SOAPAction", o.SoapAction);
            request.Headers.UserAgent.ParseAdd("OpenCezih.NET");

            if (o.Security != null &&
                !string.IsNullOrWhiteSpace(o.Security.Value.Username) &&
                !string.IsNullOrWhiteSpace(o.Security.Value.Password))
            {
                var usernamePass = $"{o.Security.Value.Username}:{o.Security.Value.Password}";
                var byteArray = Encoding.UTF8.GetBytes(usernamePass);
                request.Headers.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            }

            return request;
        }

        public Result<XmlDocument> ProcessResponse(SoapRequestResult result)
        {
            if (!result.IsSuccessStatusCode)
            {
                if (!result.IsXml)
                {
                    return new ErrorMessage(result.Content);
                }

                var envDoc = new XmlDocument();
                envDoc.LoadXml(result.Content);
                var envelope = SoapSerializer.Instance.Deserialize<Envelope11>(envDoc);
                var error = envelope.Body?.Fault?.FaultString;

                if (!string.IsNullOrEmpty(error))
                {
                    result.IsFault = true;
                    return new ErrorMessage(error);
                }

                return GetSoapBodyContents(result.Content);
            }

            if (result.IsXml)
            {
                var envDoc = new XmlDocument();
                envDoc.LoadXml(result.Content);
                var envelope = SoapSerializer.Instance.Deserialize<Envelope11>(envDoc);
                var error = envelope.Body?.Fault?.FaultString;

                if (!string.IsNullOrEmpty(error))
                {
                    result.IsFault = true;
                    return new ErrorMessage(error);
                }
            }

            return GetSoapBodyContents(result.Content);
        }

        private static string CreateEnvelope(SoapOptions opts)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(opts.XmlString);

            var envelope = new Envelope11
            {
                Header = new Header11
                {
                    Action = new SoapAction11
                    {
                        Value = opts.SoapAction,
                        MustUnderstand = opts.ActionMustUnderstand ? "1" : "0"
                    },
                    MessageId = opts.MessageId != default ? $"urn:uuid:{opts.MessageId:D}" : null,
                    To = opts.To?.ToString(),
                    ReplyTo = opts.ReplyTo != null
                        ? new ReplyTo
                        {
                            Address = opts.ReplyTo.ToString()
                        }
                        : null
                },
                Body = new Body11
                {
                    Payload = new[] { xmlDoc.DocumentElement }
                }
            };

            var soapEnvelope = SoapSerializer.Instance.Serialize(envelope);
            var soapDoc = new XmlDocument { PreserveWhitespace = true };

            soapDoc.LoadXml(soapEnvelope);
            return soapDoc.InnerXml;
        }

        private static string CreateSignedEnvelope(SoapOptions opts)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(opts.XmlString);

            var ids = new DigitalSignatureIds
            {
                RootElementId = $"id-{Guid.NewGuid():N}",
                SecurityTokenId = $"st-{Guid.NewGuid():N}",
                TimeStampElementId = $"ts-{Guid.NewGuid():N}"
            };

            var envelope = new Envelope11
            {
                Header = new Header11
                {
                    To = opts.To?.ToString(),
                    MessageId = opts.MessageId != default ? $"urn:uuid:{opts.MessageId:D}" : null,
                    Action = new SoapAction11
                    {
                        Value = opts.SoapAction,
                        MustUnderstand = opts.ActionMustUnderstand ? "1" : "0"
                    },
                    ReplyTo = opts.ReplyTo != null
                        ? new ReplyTo
                        {
                            Address = opts.ReplyTo.ToString()
                        }
                        : null,
                    Security = new SoapSecurity
                    {
                        Timestamp = opts.IncludeTimestamp
                            ? new SoapTimestamp
                            {
                                Id = ids.TimeStampElementId
                            }
                            : null,
                        Token = new SecurityToken
                        {
                            Id = ids.SecurityTokenId,
                            EncodingType = XmlNamespaces.B64Encoding,
                            ValueType = XmlNamespaces.ValueType,
                            Value = Convert.ToBase64String(opts.Certificate.RawData)
                        }
                    }
                },
                Body = new Body11
                {
                    Id = ids.RootElementId,
                    Payload = new[] { xmlDoc.DocumentElement }
                }
            };

            var nsList = new List<string>
            {
                XmlNamespaces.SoapNs11,
                XmlNamespaces.WsSecurityUtilityNs,
                XmlNamespaces.WsSecuritySecextNs,
                XmlNamespaces.AddressingNs,
            };

            var ns = XmlNamespaces.Instance.GetNamespaces(nsList);

            var soapEnvelope = SoapSerializer.Instance.Serialize(envelope, ns);
            var soapDoc = new XmlDocument { PreserveWhitespace = true };

            soapDoc.LoadXml(soapEnvelope);
            var signature = SoapEnvelopeHelper.Sign(opts, ids, soapDoc);

            var nsMgr = new XmlNamespaceManager(soapDoc.NameTable);
            nsMgr.AddNamespace("o", XmlNamespaces.WsSecuritySecextNs);
            nsMgr.AddNamespace("s", XmlNamespaces.SoapNs11);

            var secNode = soapDoc.SelectSingleNode("/s:Envelope/s:Header/o:Security", nsMgr);
            var importedSignature = soapDoc.ImportNode(signature, true);
            secNode.AppendChild(importedSignature);

            return soapDoc.InnerXml;
        }

        private static XmlDocument GetSoapBodyContents(string soapResponseString)
        {
            var soapDoc = new XmlDocument();
            soapDoc.LoadXml(soapResponseString);

            var nsmgr = new XmlNamespaceManager(soapDoc.NameTable);
            nsmgr.AddNamespace("soap", XmlNamespaces.SoapNs11);

            var bodyNode = soapDoc.SelectSingleNode("/soap:Envelope/soap:Body", nsmgr);

            if (bodyNode == null)
            {
                throw new InvalidOperationException("SOAP body not found in the response.");
            }

            var bodyDoc = new XmlDocument();
            bodyDoc.LoadXml(bodyNode.InnerXml);
            return bodyDoc;
        }
    }
}