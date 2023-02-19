namespace ApplyCoupon
{
    public class AllDiscountCoupon : ICoupon
    {
        private readonly int _dicountPercent;
        public AllDiscountCoupon(int dicountPercent)
        {
            _dicountPercent = dicountPercent;
        }
        public void ApplyDiscount(List<Item> items)
        {
            foreach (Item item in items)
            {
                item.Price -= (double)((double)(_dicountPercent / 100.0) * (double)item.Price);
            }
        }
    }
}
