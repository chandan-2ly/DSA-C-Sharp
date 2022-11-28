using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Payment
    {
        public void PayBill(Bill bill)
        {
            bill.isPaid = true;
        }
    }
}
