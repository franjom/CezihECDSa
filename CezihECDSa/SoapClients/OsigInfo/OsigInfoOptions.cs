using System;

namespace CezihECDSa.SoapClients.OsigInfo
{
    public class OsigInfoOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}