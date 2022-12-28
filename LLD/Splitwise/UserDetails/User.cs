namespace Splitwise.UserDetails
{
    public class User : UserComparable
    {
        public int Id { get; }
        public string Name { get; }
        public UserExpenseBalancesheet Balancesheet { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
            Balancesheet = new UserExpenseBalancesheet();
        }
    }
}
