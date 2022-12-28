namespace Splitwise.ExpenseDetails.SplitDetails
{
    public class UnEqualExpenseSplit : ExpenseSplit
    {
        public override bool ValidateSplitRequest(List<Split> splits, double totalAmount)
        {
            return base.ValidateTotalSplitRequest(splits, totalAmount);
        }
    }
}
