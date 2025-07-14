using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CezihECDSa.SoapClients.InjuryApplicationService
{
    public class InjuryApplicationServiceOptions
    {
        public Uri BaseUri { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}
