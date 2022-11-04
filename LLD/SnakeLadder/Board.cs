namespace SnakeLadder
{
    internal class Board
    {
        private int size;
        public Cell[][] _cells;
        
        public Board(int size, int snakesCount, int ladderCount)
        {
            this.size = size;

            InitializeCells(size);
            AddSnakes(snakesCount);
            AddLadders(ladderCount);
        }

        private void InitializeCells(int size)
        {
            _cells = new Cell[size][];

            for (int i = 0; i < size; i++)
            {
                _cells[i] = new Cell[size];
                Array.Fill(_cells[i], new Cell());
            }
        }

        private void AddLadders(int ladderCount)
        {
            while(ladderCount > 0)
            {
                Random rand = new Random();
                int ladderStart = rand.Next(3, size * size - 5);
                int ladderEnd = rand.Next(3, size * size - 5);

                if (ladderStart >= ladderEnd)
                    continue;
                
                Snake_Ladder_Jump ladderJump = new Snake_Ladder_Jump();
                ladderJump.Start = ladderStart;
                ladderJump.End = ladderEnd;

                Cell cell = GetCell(ladderStart);
                cell.SnakeLadderJump = ladderJump;

                ladderCount--;
            }
        }

        public Cell GetCell(int playerPosition)
        {
            int boardRow = playerPosition / size;
            int boardCol = playerPosition % size;

            return _cells[boardRow][boardCol];
        }

        private void AddSnakes(int snakesCount)
        {
            while (snakesCount > 0)
            {
                Random rand = new Random();
                int snakeStart = rand.Next(3, size * size - 5);
                int snakeEnd = rand.Next(3, size * size - 5);

                if (snakeEnd >= snakeStart)
                    continue;

                Snake_Ladder_Jump SnakeJump = new Snake_Ladder_Jump();
                SnakeJump.Start = snakeStart;
                SnakeJump.End = snakeEnd;

                Cell cell = GetCell(snakeStart);
                cell.SnakeLadderJump = SnakeJump;

                snakesCount--;
            }
        }
    }
}