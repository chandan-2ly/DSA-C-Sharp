namespace ATMDispenseMachine
{
    public class Currency
    {
        public int Amount { get; private set; }

        public Currency(int amount)
        {
            Amount = amount;
        }
    }
}
