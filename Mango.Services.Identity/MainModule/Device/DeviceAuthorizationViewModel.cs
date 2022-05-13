using Globe.Services.Identity.MainModule.Consent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globe.Services.Identity.MainModule.Device
{
    public class DeviceAuthorizationViewModel : ConsentViewModel
    {
        public string UserCode { get; set; }
        public bool ConfirmUserCode { get; set; }
        public List<ScopeViewModel> ApiScopes { get; internal set; }
    }
}