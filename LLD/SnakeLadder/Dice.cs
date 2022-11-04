namespace SnakeLadder
{
    internal class Dice
    {
        private int diceCount;
        int min = 1;
        int max = 6;

        public Dice(int diceCount)
        {
            this.diceCount = diceCount;
        }

        public int RollDice()
        {
            int diceUsed = 0;
            int totalSum = 0;
            Random random = new Random();

            while(diceUsed < diceCount)
            {
                totalSum += random.Next(min, max);
                diceUsed++;
            }

            return totalSum;
        }
    }
}