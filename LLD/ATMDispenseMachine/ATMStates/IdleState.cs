using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDispenseMachine.ATMStates
{
    public class IdleState : AtmStates
    {
        public override void InsertCard(Atm atm, Card card)
        {
            Console.WriteLine("Card is inserted");
            atm.SetCurrentState(new HasCardState());
        }
    }
}
