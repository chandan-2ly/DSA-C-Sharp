using Splitwise.ExpenseDetails;
using Splitwise.ExpenseDetails.SplitDetails;
using Splitwise.UserDetails;

namespace Splitwise
{
    public class Group
    {
        public int Id { get;}
        public List<User> GroupMembers { get;}
        public string GroupName { get;}
        public string Description { get;}

        public List<Expense> Expenses { get; }

        public ExpenseController _expenseController;

        public Group(int id, List<User> users, string groupName, string description)
        {
            Id = id;
            GroupMembers = users;
            GroupName = groupName;
            Description = description;
            _expenseController = new ExpenseController();
            Expenses = new List<Expense>();
        }

        public void AddMember(User user)
        {
            GroupMembers.Add(user);
        }

        public void CreateExpense(int expenseId, string description, int expenseAmount, List<Split> splitDetails, ExpenseSplitType eQUAL, User paidByUserId)
        {
            var expense = _expenseController.CreateExpense(expenseId, description, expenseAmount, splitDetails, eQUAL, paidByUserId);
            if(expense != null)
                Expenses.Add(expense);
        }
    }
}
