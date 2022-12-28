using Splitwise.ExpenseDetails;
using Splitwise.ExpenseDetails.SplitDetails;
using Splitwise.UserDetails;

namespace Splitwise
{
    public class SplitwiseApp
    {
        private readonly UserController userController;
        private readonly GroupController groupController;
        private readonly BalanceSheetController balanceSheet;

        public SplitwiseApp()
        {
            userController = new UserController();
            groupController = new GroupController();
            balanceSheet = new BalanceSheetController();
        }

        public void Demo()
        {
            userController.AddUser(new User(1, "Chandan"));
            userController.AddUser(new User(2, "Ranjan"));
            //userController.AddUser(new User(3, "Ravi"));

            Group group = new Group(1, userController.GetUsers(), "Group 1", "Home Expense");
            group.AddMember(new User(3, "Ravi"));
            groupController.AddGroup(group);

            //client computed the split and send to the server
            List<Split> splits = new List<Split>();
            var split1 = new Split(userController.GetUser(1), 166.67);
            var split2 = new Split(userController.GetUser(2), 166.67);
            var split3 = new Split(userController.GetUser(3), 166.66);
            splits.Add(split1);
            splits.Add(split2);
            splits.Add(split3);

            group.CreateExpense(expenseId: 100, description: "Vegetables", expenseAmount: 500, splitDetails: splits
                , ExpenseSplitType.EQUAL, paidByUserId: userController.GetUser(2));

            balanceSheet.ShowBalanceSheet(userController.GetUser(1));

        }
    }
}
