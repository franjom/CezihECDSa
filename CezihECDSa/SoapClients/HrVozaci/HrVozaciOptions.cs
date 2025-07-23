using System;

namespace CezihECDSa.SoapClients.PrijavaZarazne
{
    public class HrVozaciOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}