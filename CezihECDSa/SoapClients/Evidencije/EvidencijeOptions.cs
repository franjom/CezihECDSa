using System;

namespace CezihECDSa.SoapClients.Evidencije
{
    public class EvidencijeOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}