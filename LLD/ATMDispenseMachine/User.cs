namespace ATMDispenseMachine
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Card CardDetails { get; set; }
        public BankAccount Account { get; set; }

        public User(int id, string name, Card cardDetails, BankAccount account)
        {
            Id = id;
            Name = name;
            CardDetails = cardDetails;
            Account = account;
        }
    }
}