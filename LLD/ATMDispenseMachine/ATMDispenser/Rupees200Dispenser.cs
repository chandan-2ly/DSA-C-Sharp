namespace ATMDispenseMachine.ATMDispenser
{
    public class Rupees200Dispenser : IAmountDispenser
    {
        private IAmountDispenser nextDispenser;
        private const int _amnt = 200;
        private const NoteType noteType = NoteType.TWOHUNDRED;

        public void DispenceAmount(Atm atm, Currency currency)
        {
            if (currency != null && currency.Amount >= _amnt)
            {
                if (atm.GetAtmBalance() < currency.Amount)
                {
                    Console.WriteLine("Unable to dispence amount from atm.");
                    return;
                }

                int remainder = currency.Amount;
                int noteCount = currency.Amount / _amnt;
                int dispensedCount = 0;

                while (atm.GetNoteCount(noteType) > 0 && noteCount > 0)
                {
                    dispensedCount++;
                    atm.DeductNote(noteType, 1);
                    noteCount--;
                    remainder = remainder - _amnt;
                }

                if (dispensedCount > 0)
                    Console.WriteLine($"Dispensing {dispensedCount} notes of {_amnt} :- {_amnt} x {dispensedCount} = {_amnt * dispensedCount}");
                if (remainder > 0)
                {
                    nextDispenser.DispenceAmount(atm, new Currency(remainder));
                }
            }
            else
            {
                nextDispenser.DispenceAmount(atm, currency);
            }
        }

        public void SetNextDispenser(IAmountDispenser dispenser)
        {
            nextDispenser = dispenser;
        }
    }
}
