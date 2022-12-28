namespace Splitwise.UserDetails
{
    public class UserPayment
    {
        public User User { get;}
        public double Amount { get;}

        public UserPayment(User user, double amount)
        {
            User = user;
            Amount = amount;
        }
    }
}
