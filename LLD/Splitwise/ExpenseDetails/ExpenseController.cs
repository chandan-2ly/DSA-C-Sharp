using Splitwise.ExpenseDetails.SplitDetails;
using Splitwise.UserDetails;

namespace Splitwise.ExpenseDetails
{
    public class ExpenseController
    {
        public BalanceSheetController _balanceSheetController;

        public ExpenseController()
        {
            _balanceSheetController = new BalanceSheetController();
        }

        public Expense CreateExpense(int expenseId, string description, double expenseAmount, List<Split> splitDetails, ExpenseSplitType splitType, 
            User paidByUserId)
        {
            ExpenseSplit exSplit = SplitFactory.GetExpenseSplit(splitType);
            if(!exSplit.ValidateSplitRequest(splitDetails, expenseAmount))
            {
                throw new Exception("Amount entered is not valid");
            }

            var expense =  new Expense(expenseId, description, expenseAmount, paidByUserId, splitType, splitDetails);
            
            _balanceSheetController.UpdateUserExpenseBalanceSheet(paidByUserId, splitDetails, expenseAmount);

            return expense;
        }
    }
}