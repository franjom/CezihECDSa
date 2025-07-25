using System;

namespace CezihECDSa.SoapClients.NarucivanjeWS
{
    public class DohvatSmjernicaOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}