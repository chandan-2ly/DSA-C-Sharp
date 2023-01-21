namespace SnakeLadder
{
    internal class Game
    {
        private Board _board;
        private Dice _dice;
        private List<Player> _players;
        private Player winner;

        public Game()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            _board = new Board(10, 5, 4);
            _dice = new Dice(1);
            _players = new List<Player>();
            winner = null;
            
            AddPlayers();
        }

        private void AddPlayers()
        {
            Player player1 = new Player("Chandan", 0);
            Player player2 = new Player("Ranjan", 0);

            _players.Add(player1);
            _players.Add(player2);
        }

        internal void Start()
        {
            while(winner == null)
            {
                Player playerTurn = FindPlayerTurn();
                Console.WriteLine("player turn is:" + playerTurn.Name + " current position is: " + playerTurn.currentPosition);

                //Roll the dice
                int count =_dice.RollDice();

                //get new position
                int playerNewPosition = playerTurn.currentPosition + count;
                playerNewPosition = CheckJump(playerNewPosition);
                playerTurn.currentPosition = playerNewPosition;

                Console.WriteLine("player turn is:" + playerTurn.Name + " new position is: " + playerTurn.currentPosition);

                //check for winning condition
                if(playerNewPosition >= _board._cells.Length * _board._cells.Length - 1)
                {
                    winner = playerTurn;
                }
            }

            Console.WriteLine("Winner is: " + winner.Name);
        }

        private int CheckJump(int playerNewPosition)
        {
            if(playerNewPosition > _board._cells.Length * _board._cells.Length - 1)
            {
                return playerNewPosition;
            }

            Cell cell = _board.GetCell(playerNewPosition);
            if(cell.SnakeLadderJump != null && cell.SnakeLadderJump.Start == playerNewPosition)
            {
                string jumpBy = cell.SnakeLadderJump.Start < cell.SnakeLadderJump.End ? "Ladder" : "Snake";
                Console.WriteLine("Jump done by: " + jumpBy);
                return cell.SnakeLadderJump.End;
            }
            return playerNewPosition;
        }

        private Player FindPlayerTurn()
        {
            Player player = _players[0];
            _players.RemoveAt(0);
            _players.Add(player);
            return player;
        }
    }
}
