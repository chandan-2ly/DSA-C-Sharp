namespace Elevator
{
    internal class Floor
    {
        public int id;
        private readonly ExternalButton _externalButton;

        public Floor(int floorNumber)
        {
            id = floorNumber;
            _externalButton = new ExternalButton();
        }

        public void PressButton(int currentFloor, Direction dir)
        {
            _externalButton.PressButton(currentFloor, dir);
        }
    }
}
