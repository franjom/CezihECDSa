using System;

namespace CezihECDSa.SoapClients.CezihWs
{
    public class CezihWsOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}