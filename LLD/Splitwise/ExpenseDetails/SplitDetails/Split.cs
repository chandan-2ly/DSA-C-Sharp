using Splitwise.UserDetails;

namespace Splitwise.ExpenseDetails.SplitDetails
{
    public class Split
    {
        public User User { get; }
        public double Amount { get; }
        public double? Percent { get; }

        public Split(User user, double amount, double? percent = null)
        {
            User = user;
            Amount = amount;
            Percent = percent;
        }

    }
}