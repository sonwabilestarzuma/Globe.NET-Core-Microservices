using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globe.Services.ShoppingCartAPI.Models.Dto
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }

        public static implicit operator CouponDto(CouponAPI.Models.Dto.CouponDto v)
        {
            throw new NotImplementedException();
        }
    }
}