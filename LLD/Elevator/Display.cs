using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class Display
    {
        public int floor;
        private Direction _direction;

        public void SetDisplay(int floorNumber, Direction direction)
        {
            this.floor = floorNumber;
            _direction = direction;
        }

        public void ShowDisplay()
        {
            Console.WriteLine("Floor:- "+floor);
            Console.WriteLine("Direction:- " + _direction.ToString());
        }
    }
}
