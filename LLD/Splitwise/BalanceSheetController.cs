using Splitwise.ExpenseDetails.SplitDetails;
using Splitwise.UserDetails;

namespace Splitwise
{
    public class BalanceSheetController
    {
        public void UpdateUserExpenseBalanceSheet(User paidByuser, List<Split> splits, double totalExpenseAmount)
        {
            var paidByUserBalanceSheet = paidByuser.Balancesheet;

            //update the total amount paid by paidByUser
            paidByUserBalanceSheet.TotalAmount += totalExpenseAmount;

            foreach(var split in splits)
            {
                User userOwe = split.User;
                var userOweBalanceSheet = userOwe.Balancesheet;

                if (userOwe.Id == paidByuser.Id)
                {
                    userOweBalanceSheet.TotalExpense += split.Amount;
                }
                else
                {
                    //update balance sheet of paidbyUser
                    paidByUserBalanceSheet.TotalGetBack += split.Amount;

                    if (paidByUserBalanceSheet.UsersBalance.ContainsKey(userOwe)){
                        paidByUserBalanceSheet.UsersBalance[userOwe].GetBack += split.Amount;
                    }
                    else
                    {
                        paidByUserBalanceSheet.UsersBalance.Add(userOwe, new FriendBalance() { GetBack = split.Amount });
                    }

                    //update the balancesheet of owe user
                    userOweBalanceSheet.TotalOwe += split.Amount;
                    userOweBalanceSheet.TotalExpense += split.Amount;

                    if (userOweBalanceSheet.UsersBalance.ContainsKey(paidByuser))
                    {
                        userOweBalanceSheet.UsersBalance[paidByuser].Owe += split.Amount;
                    }
                    else
                    {
                        userOweBalanceSheet.UsersBalance.Add(paidByuser, new FriendBalance() { Owe = split.Amount });
                    }
                }

            }


        }
        public void ShowBalanceSheet(User user)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"Balance Sheet of User {user.Name}");
            Console.WriteLine($"Your Total Expense is {Math.Round(user.Balancesheet.TotalExpense,2)}");
            Console.WriteLine($"Your Total Paid Amount is {Math.Round(user.Balancesheet.TotalAmount,2)}");
            Console.WriteLine($"Your Total GetBack Amount is {Math.Round(user.Balancesheet.TotalGetBack, 2)}");
            Console.WriteLine($"Your Total Owe Amount is {Math.Round(user.Balancesheet.TotalOwe, 2)}");

            Console.WriteLine($"\nYour Total Balance is {Math.Round(user.Balancesheet.TotalBalance, 2)}");

            foreach (var friend in user.Balancesheet.UsersBalance)
            {
                if (friend.Value.Balance > 0)
                    Console.WriteLine($"{friend.Key.Name} owes {user.Name}: {friend.Value.Balance}");
                if (friend.Value.Balance < 0)
                    Console.WriteLine($"{user.Name} owes {friend.Key.Name}: {-friend.Value.Balance}");
            }
        }

        public void ShowBalanceSheet(List<User> users)
        {
            //Console.WriteLine("------------------------------------------------------------------");
            if (users != null)
            {
                foreach (var user in users)
                {
                    var userBalanceSheet = user.Balancesheet;
                    if (userBalanceSheet.UsersBalance.Count > 0)
                    {
                        ShowBalanceSheet(user);
                    }
                }
            }
        }
    }
}