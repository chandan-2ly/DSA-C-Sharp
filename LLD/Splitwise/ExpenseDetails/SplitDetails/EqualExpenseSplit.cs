namespace Splitwise.ExpenseDetails.SplitDetails
{
    public class EqualExpenseSplit : ExpenseSplit
    {
        public override bool ValidateSplitRequest(List<Split> splits, double totalAmount)
        {
            
            if(!base.ValidateTotalSplitRequest(splits, totalAmount)){ return false; }

            double amt = totalAmount / splits.Count;
            amt = Math.Round(amt, 2);

            foreach(var split in splits)
            {
                if(!(split.Amount == amt || split.Amount == amt-0.01 || split.Amount == amt + 0.01)) { return false; }
            }
            return true;
        }
        
    }
}
