namespace ATMDispenseMachine
{
    public class Rupees100Dispenser : IAmountDispenser
    {
        private IAmountDispenser nextDispenser;

        public void DispenceAmount(Currency currency)
        {
            if(currency != null && currency.Amount >= 100)
            {
                int noteCount = currency.Amount / 100;
                int remainder = currency.Amount % 100;

                Console.WriteLine($"Dispensing {noteCount} notes of 100 :- 100 x {noteCount} = {100 * noteCount}");
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
