using System;

namespace CezihECDSa.SoapClients.SkolskaMedicina
{
    public class SkolskaMedicinaOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}