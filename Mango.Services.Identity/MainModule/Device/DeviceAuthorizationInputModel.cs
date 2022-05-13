using Globe.Services.Identity.MainModule.Consent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globe.Services.Identity.MainModule.Device
{
    public class DeviceAuthorizationInputModel : ConsentInputModel
    {
        public string UserCode { get; set; }
        public string Description { get; internal set; }
        public IEnumerable<string> ScopesConsented { get; internal set; }
    }
}