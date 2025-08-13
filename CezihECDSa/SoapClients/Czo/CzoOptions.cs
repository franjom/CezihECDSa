using System;

namespace CezihECDSa.SoapClients.PrijavaZarazne
{
    public class CzoOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}