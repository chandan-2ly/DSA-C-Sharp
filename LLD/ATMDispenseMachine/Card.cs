namespace ATMDispenseMachine
{
    public class Card
    {
        private int CardNumber { get; set; }
        private string CardName { get; set; }
        private int CVV { get; set; }
        private string CardHolderName { get; set; }
        private BankAccount AccountAssociated { get; set; }
        private int Pin { get; set; }

        public Card(int cardNumber, string cardName, int cVV, string cardHolderName, BankAccount accountAssociated, int pin)
        {
            CardNumber = cardNumber;
            CardName = cardName;
            CVV = cVV;
            CardHolderName = cardHolderName;
            AccountAssociated = accountAssociated;
            Pin = pin;
        }
        public bool IsEnteredPinCorrect(int pin)
        {
            return Pin == pin;
        }
        public int GetCardBalance()
        {
            return AccountAssociated.AccountBalance;
        }
        public void Withdraw(int amount)
        {
            AccountAssociated.WithdrawalBalance(amount);
            Console.WriteLine("Available Card Balance: " + GetCardBalance());
        }
    }
}