using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    public class ElevatorController
    {
        public readonly ElevatorCar _elevatorCar;
        PriorityQueue<int, int> minHeap;        //required for up
        PriorityQueue<int, int> maxHeap;        //required for down

        public ElevatorController(ElevatorCar elevatorCar)
        {
            _elevatorCar = elevatorCar;
            minHeap = new PriorityQueue<int, int>();
            maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x,y) => y-x));
        }

        public void AcceptNewRequest(int floor, Direction dir)
        {
            if(dir == Direction.UP)
            {
                minHeap.Enqueue(floor, floor);
            }
            else if(dir == Direction.DOWN)
            {
                maxHeap.Enqueue(floor, floor);
            }

        }
        public void ControlElevator()
        {
            while (true)
            {

            }

        }
    }
}
