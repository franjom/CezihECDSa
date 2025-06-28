using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Xml;

namespace CezihECDSa.Logging
{
    public class LoggingMessageInspector : IClientMessageInspector
    {
        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            var copy = CopyMessage(ref request);
            Debug.WriteLine("===== OUTGOING SOAP REQUEST =====");
            Debug.WriteLine(copy);
            Debug.WriteLine("=================================");
            return null;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            var copy = CopyMessage(ref reply);
            Debug.WriteLine("===== INCOMING SOAP RESPONSE =====");
            Debug.WriteLine(copy);
            Debug.WriteLine("==================================");
        }

        private string CopyMessage(ref Message message)
        {
            var buffer = message.CreateBufferedCopy(int.MaxValue);
            var copy = buffer.CreateMessage();
            message = buffer.CreateMessage(); // restore original for WCF pipeline

            using (var sw = new System.IO.StringWriter())
            using (var xw = XmlWriter.Create(sw, new XmlWriterSettings { Indent = true }))
            {
                copy.WriteMessage(xw);
                xw.Flush();
                return sw.ToString();
            }
        }
    }

    public class LoggingEndpointBehavior : IEndpointBehavior
    {
        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(new LoggingMessageInspector());
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }
    }
}