using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    public class ElevatorCar
    {
        public int carId;
        private readonly Display _display;
        private int currentFloor;
        private Direction _direction;
        private Status _status;
        private readonly InternalButton _internalButton;

        public ElevatorCar()
        {
            _display = new Display();
            _internalButton = new InternalButton();
            _status = Status.IDLE;
            currentFloor = 0;
            _direction = Direction.UP;

        }

        public void ShowDisplay()
        {
            _display.ShowDisplay();
        }

        public void PressButton(int destinationFloor)
        {
            _internalButton.PressButton(destinationFloor, this);
        }

        public void SetDisplay()
        {
            _display.SetDisplay(currentFloor, _direction);
        }
        public void MoveElevator(int destinationFloor, Direction dir)
        {
            int startFloor = currentFloor;
            if(dir == Direction.UP)
            {
                for(int i = startFloor; i <= destinationFloor; i++)
                {
                    currentFloor = i;
                    SetDisplay();
                    ShowDisplay();
                    if (i == destinationFloor)
                    {
                        Console.WriteLine("Your Destination is reached");
                    }
                }
            }
            else if(dir == Direction.DOWN)
            {
                for(int i = startFloor; i >= destinationFloor; i--)
                {
                    currentFloor = i;
                    SetDisplay();
                    ShowDisplay();
                    if(i == destinationFloor)
                    {
                        Console.WriteLine("Your Destination is reached");
                    }
                }
            }
        }
    }
}
