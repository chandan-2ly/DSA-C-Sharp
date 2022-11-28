namespace Elevator
{
    internal class ExternalButtonDispatcher
    {
        public List<ElevatorController> _elevatorControllers = ElevatorCreator.CreateElevator();

        public void SubmitRequest(int currentFloor, Direction dir)
        {
            //even odd logic
            foreach(var elevatorController in _elevatorControllers)
            {
                int elevatorId = elevatorController._elevatorCar.carId;
                if(elevatorId % 2 == 0 && currentFloor % 2 == 0)
                {
                    elevatorController.AcceptNewRequest(currentFloor, dir);
                }
                else if(elevatorId % 2 == 1 && currentFloor % 2 == 1)
                {
                    elevatorController.AcceptNewRequest(currentFloor, dir);
                }
            }

        }
    }
}
