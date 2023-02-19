using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDispenseMachine.ATMStates
{
    public class SelectOperationState : AtmStates
    {
        public SelectOperationState()
        {
            ShowOperation();
        }

        public override void SelectOperation(Atm atm, Card card, TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.CASH_WITHDRAWAL:
                    atm.SetCurrentState(new CashWithdrawalState());
                    break;
                case TransactionType.BALANCE_CHECK:
                    atm.SetCurrentState(new CheckBalanceState());
                    break;
                default:
                    Console.WriteLine("Invalid option selected");
                    Exit(atm);
                    break;
            }
        }

        private void ShowOperation()
        {
            var opsList = Enum.GetNames(typeof(TransactionType)).ToList();
            if(opsList != null && opsList.Count > 0)
            {
                foreach(var op in opsList)
                {
                    Console.WriteLine(op);
                }
                
            }
        }
    }
}
