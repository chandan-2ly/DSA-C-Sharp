using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDispenseMachine.ATMStates
{
    public abstract class AtmStates
    {
        public virtual void InsertCard(Atm atm, Card card)
        {
            Console.WriteLine("Some thing went wrong");
        }
        public virtual void AuthenticatePin(Atm atm, Card card, int pin)
        {
            Console.WriteLine("Some thing went wrong");
        }
        public virtual void SelectOperation(Atm atm, Card card, TransactionType transactionType)
        {
            Console.WriteLine("Some thing went wrong");
        }
        public virtual void CashWithdrawal(Atm atm, Card card, int withdrawAmount)
        {
            Console.WriteLine("Some thing went wrong");
        }
        public virtual void DiplayBalance(Atm atm, Card card)
        {
            Console.WriteLine("Some thing went wrong");
        }

        public void Exit(Atm atm)
        {
            Return();
            atm.SetCurrentState(new IdleState());
            Console.WriteLine("Exit Happens");
        }

        public void Return()
        {
            Console.WriteLine("Please collect your card");
        }
    }
}
