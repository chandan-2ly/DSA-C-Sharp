using Splitwise.ExpenseDetails.SplitDetails;
using Splitwise.UserDetails;

namespace Splitwise.ExpenseDetails
{
    public class Expense
    {
        public int Id { get; }
        public string Description { get; }
        public double Amount { get; }
        public User PaidByUser { get; }
        public ExpenseSplitType SplitType { get; }

        public List<Split> SplitDetails { get; }

        public Expense(int id, string name, double amount, User paidByUser, ExpenseSplitType splitType, List<Split> splitDetails)
        {
            Id = id;
            Description = name;
            Amount = amount;
            PaidByUser = paidByUser;
            SplitType = splitType;
            SplitDetails = splitDetails;
        }
    }
}
