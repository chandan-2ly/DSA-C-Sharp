using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutStrategyDesignPattern
{
    internal class PassengerVehicle : Vehicle
    {
        protected void Drive()
        {
            Console.WriteLine("Drive normally");
        }
    }
}
