namespace Splitwise.UserDetails
{
    public class UserExpenseBalancesheet
    {
        public Dictionary<User, FriendBalance> UsersBalance = new Dictionary<User, FriendBalance>(new UserComparable());
        public double TotalAmount { get; set; }
        public double TotalExpense { get; set; }
        public double TotalOwe { get; set; }
        public double TotalGetBack { get; set; }
    }
}