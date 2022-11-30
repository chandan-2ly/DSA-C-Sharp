using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStrategyDesignPattern
{
    internal class Vehicle
    {
        private readonly IDriveStrategy _strategy;

        public Vehicle(IDriveStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Drive()
        {
            _strategy.Drive();
        }
    }
}
