namespace ATMDispenseMachine
{
    public class Rupees500Dispenser : IAmountDispenser
    {
        private IAmountDispenser nextDispenser;

        public void DispenceAmount(Currency currency)
        {
            if (currency != null && currency.Amount >= 500)
            {
                int noteCount = currency.Amount / 500;
                int remainder = currency.Amount % 500;

                Console.WriteLine($"Dispensing {noteCount} notes of 500 :- 500 x {noteCount} = {500 * noteCount}");
                if (remainder > 0)
                {
                    nextDispenser.DispenceAmount(new Currency(remainder));
                }
            }
            else
            {
                nextDispenser.DispenceAmount(currency);
            }
        }

        public void SetNextDispenser(IAmountDispenser dispenser)
        {
            nextDispenser = dispenser;
        }
    }
}
