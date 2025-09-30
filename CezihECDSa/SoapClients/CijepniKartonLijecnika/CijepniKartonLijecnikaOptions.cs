using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CezihECDSa.SoapClients.CijepniKartonLijecnika
{
    public class CijepniKartonLijecnikaOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}
