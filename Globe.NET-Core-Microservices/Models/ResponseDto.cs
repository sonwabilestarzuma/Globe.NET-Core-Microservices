using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globe.NET_Core_Microservices.Models
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessages { get; set; }
    }
}