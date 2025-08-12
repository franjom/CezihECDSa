using System;

namespace CezihECDSa.SoapClients.NRS
{
    public class NRSOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}