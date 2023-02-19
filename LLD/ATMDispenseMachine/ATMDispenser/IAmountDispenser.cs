namespace ATMDispenseMachine.ATMDispenser
{
    public interface IAmountDispenser
    {
        public void DispenceAmount(Atm atm, Currency currency);
        public void SetNextDispenser(IAmountDispenser dispenser);
    }
}
