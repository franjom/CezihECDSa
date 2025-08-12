using CezihECDSa.Wsdl;
using System;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.NRS.Wrappers
{
    [XmlRoot("ReferenceScoreResult", Namespace = "http://tempuri.org/")]
    public sealed class WReferenceScoreResult
    {
        public WReferenceScoreResult() { }
        public WReferenceScoreResult(ReferenceScoreResult referenceScoreResult)
        {
            ReferenceScoreResult = referenceScoreResult;
        }
        public ReferenceScoreResult ReferenceScoreResult { get; set; }
    }
}
