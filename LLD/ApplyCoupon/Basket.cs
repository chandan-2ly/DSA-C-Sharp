using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyCoupon
{
    public class Basket
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public List<ICoupon> Coupons { get; set; } = new List<ICoupon>();
        public double CalculateTotalPrice()
        {
            foreach (var coupon in Coupons)
            {
                coupon.ApplyDiscount(Items);
            }
            return (double)Items.Sum(x => x.Price);
        }
    }
}
