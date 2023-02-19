namespace ATMDispenseMachine.ATMStates
{
    public class CashWithdrawalState : AtmStates
    {
        public CashWithdrawalState()
        {
            Console.WriteLine("Please enter amount to withdraw");
        }

        public override void CashWithdrawal(Atm atm, Card card, int withdrawAmount)
        {
            if(atm.GetAtmBalance() < withdrawAmount)
            {
                Console.WriteLine("Insufficient balance in Atm machine");
            }
            else if(card.GetCardBalance() < withdrawAmount)
            {
                Console.WriteLine("Insufficient balance in user account");
            }
            else
            {
                atm.AtmAmountDispenser.DispenceAmount(atm, new Currency(withdrawAmount));
                card.Withdraw(withdrawAmount);
                Exit(atm);
            }
        }
    }
}