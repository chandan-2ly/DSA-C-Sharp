using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitwise.ExpenseDetails.SplitDetails
{
    public class SplitController
    {
        List<Split> splits;

        public SplitController()
        {
            splits = new List<Split>();
        }

        public List<Split> ComputeAndGetSplits(string users, string amount, ExpenseSplitType splitType)
        {
            var userList = users.Split(' ');
            var amountList = amount.Split(' ');

            //foreach(var user in userList)
            //{

            //}
            return null;
        }
    }
}
