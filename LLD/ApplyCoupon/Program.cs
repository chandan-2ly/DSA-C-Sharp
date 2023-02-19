namespace ApplyCoupon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item() { Id = 1, Name = "item1", Price = 501, Type = ItemType.CLOTHING };
            Item item2 = new Item() { Id = 1, Name = "item2", Price = 456, Type = ItemType.ENTERTAINMENT };
            Item item3 = new Item() { Id = 1, Name = "item3", Price = 1000, Type = ItemType.KITCHEN };
            Item item4 = new Item() { Id = 1, Name = "item4", Price = 800, Type = ItemType.ELECTRICALS };

            Basket basket = new Basket();
            basket.Items.Add(item);
            basket.Items.Add(item2);
            basket.Items.Add(item3);
            basket.Items.Add(item4);

            ICoupon coupon = new AllDiscountCoupon(20);
            basket.Coupons.Add(coupon);
            Console.WriteLine("Total Price after discount is: " + basket.CalculateTotalPrice());
        }
    }
}