namespace Elevator
{
    internal class Building
    {
        public List<Floor> _floors;
        public Building(List<Floor> floors)
        {
            _floors = floors;
        }

        public void AddFloor(Floor floor)
        {
            _floors.Add(floor);
        }
        public void RemoveFloor(int id)
        {
            _floors.Remove(_floors[id]);
        }

        public List<Floor> GetAllFloor()
        {
            return _floors;
        }
    }
}
