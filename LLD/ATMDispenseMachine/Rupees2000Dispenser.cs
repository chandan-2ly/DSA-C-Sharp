using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDispenseMachine
{
    public class Rupees2000Dispenser : IAmountDispenser
    {
        private IAmountDispenser nextDispenser;

        public void DispenceAmount(Currency currency)
        {
            if (currency != null && currency.Amount >= 2000)
            {
                int noteCount = currency.Amount / 2000;
                int remainder = currency.Amount % 2000;

                Console.WriteLine($"Dispensing {noteCount} notes of 2000 :- 2000 x {noteCount} = {2000 * noteCount}");
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
