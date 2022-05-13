using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globe.NET_Core_Microservices.Models
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }
    }
}