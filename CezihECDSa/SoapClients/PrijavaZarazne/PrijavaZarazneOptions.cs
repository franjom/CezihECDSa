using System;

namespace CezihECDSa.SoapClients.PrijavaZarazne
{
    public class PrijavaZarazneOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}