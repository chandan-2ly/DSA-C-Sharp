using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDispenseMachine.ATMStates
{
    public class HasCardState : AtmStates
    {
        public HasCardState()
        {
            Console.WriteLine("Card is in HasCardState");
            Console.WriteLine("Enter your card pin number");
        }

        public override void AuthenticatePin(Atm atm, Card card, int pin)
        {
            if(card != null && card.IsEnteredPinCorrect(pin))
            {
                Console.WriteLine("Pin is correct");
                atm.SetCurrentState(new SelectOperationState());
            }
            else
            {
                Console.WriteLine("Entered pin is wrong");
                Exit(atm);
            }
        }

        
    }
}
