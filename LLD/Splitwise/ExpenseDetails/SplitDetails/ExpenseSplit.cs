namespace Splitwise.ExpenseDetails.SplitDetails
{
    public abstract class ExpenseSplit
    {
        public virtual bool ValidateTotalSplitRequest(List<Split> splits, double totalAmount)
        {
            if (splits.Count == 0 || totalAmount == 0.0) return false;

            var isSumEquatToTotal = splits.Sum(x => x.Amount) == totalAmount;
            if (!isSumEquatToTotal)
            {
                return false;
            }

            return true;
        }

        public abstract bool ValidateSplitRequest(List<Split> splits, double totalAmount);
    }
}
