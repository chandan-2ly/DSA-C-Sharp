namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Floor> floorList = new List<Floor>();

            for(int i = 0; i < 5; i++)
            {
                Floor floor = new Floor(i + 1);
                floorList.Add(floor);
            }
            Building building = new Building(floorList);

            Console.WriteLine("Press button to go up or down, 0 for up and 1 for down");
            int currentFloor = floorList[0].id;
            int direction = int.Parse(Console.ReadLine());
            string dir = direction == 0 ? "UP" : "DOWN";
            Console.WriteLine("Your Current Floor is " + currentFloor + " and you have pressed " + dir + " key");
            building._floors[currentFloor].PressButton(currentFloor, (Direction)direction);
        }
    }
}