namespace ATMDispenseMachine.ATMStates
{
    internal class CheckBalanceState : AtmStates
    {
        public override void DiplayBalance(Atm atm, Card card)
        {
            Console.WriteLine("Your Available Balance is: "+card.GetCardBalance());
            Exit(atm);
        }
    }
}