namespace ATMDispenseMachine
{
    public class Rupees200Dispenser : IAmountDispenser
    {
        private IAmountDispenser nextDispenser;

        public void DispenceAmount(Currency currency)
        {
            if (currency != null && currency.Amount >= 200)
            {
                int noteCount = currency.Amount / 200;
                int remainder = currency.Amount % 200;

                Console.WriteLine($"Dispensing {noteCount} notes of 200 :- 200 x {noteCount} = {200 * noteCount}");
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
