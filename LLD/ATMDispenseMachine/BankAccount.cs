namespace ATMDispenseMachine
{
    public class BankAccount
    {
        public int AccountBalance { get; set; }

        public BankAccount(int accountBalance)
        {
            AccountBalance = accountBalance;
        }

        public void WithdrawalBalance(int amount)
        {
            AccountBalance -= amount;
            
        }
    }
}