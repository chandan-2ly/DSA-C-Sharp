using Splitwise.ExpenseDetails;

namespace Splitwise.ExpenseDetails.SplitDetails
{
    public class SplitFactory
    {
        public static ExpenseSplit GetExpenseSplit(ExpenseSplitType splitType)
        {
            switch (splitType)
            {
                case ExpenseSplitType.EQUAL:
                    return new EqualExpenseSplit();

                case ExpenseSplitType.UNEQUAL:
                    return new UnEqualExpenseSplit();

                case ExpenseSplitType.PERCENTAGE:
                    return new PercentageExpenseSplit();
            }

            return null;
        }
    }
}
