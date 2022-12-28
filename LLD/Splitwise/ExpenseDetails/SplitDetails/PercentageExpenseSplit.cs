namespace Splitwise.ExpenseDetails.SplitDetails
{
    public class PercentageExpenseSplit : ExpenseSplit
    {
        public override bool ValidateSplitRequest(List<Split> splits, double totalAmount)
        {
            return splits.Any(x => x.Amount != x.Percent % totalAmount);
        }
    }
}
