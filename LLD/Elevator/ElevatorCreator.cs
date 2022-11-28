namespace Elevator
{
    public static class ElevatorCreator
    {
        public static List<ElevatorController> CreateElevator()
        {
            List<ElevatorController> elevatorControllers = new List<ElevatorController>();

            ElevatorCar car1 = new ElevatorCar();
            car1.carId = 1;
            elevatorControllers.Add(new ElevatorController(car1));

            ElevatorCar car2 = new ElevatorCar();
            car1.carId = 2;
            elevatorControllers.Add(new ElevatorController(car1));

            return elevatorControllers;
        }
    }
}
