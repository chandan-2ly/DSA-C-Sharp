namespace ATMDispenseMachine
{
    public interface IAmountDispenser
    {
        public void DispenceAmount(Currency currency);
        public void SetNextDispenser(IAmountDispenser dispenser);
    }
}
