using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Globe.NET_Core_Microservices.SD;

namespace Globe.NET_Core_Microservices.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
