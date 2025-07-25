using System;

namespace CezihECDSa.SoapClients.HrVozaci
{
    public class HrVozaciOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}