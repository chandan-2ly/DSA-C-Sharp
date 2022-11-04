namespace SnakeLadder
{
    internal class Player
    {
        public string Name { get; set; }
        public int currentPosition;

        public Player(string name, int currentPosition)
        {
            Name = name;
            this.currentPosition = currentPosition;
        }
    }
}