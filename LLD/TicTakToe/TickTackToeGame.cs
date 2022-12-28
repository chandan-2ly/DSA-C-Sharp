namespace TicTakToe
{
    internal class TickTackToeGame
    {
        private Board _board;
        private List<Player> _players;
        internal void InitializeGame()
        {
            _players = new List<Player>();
            Player player1 = new Player("Player1", new PlayingPiece(PieceType.X));
            Player player2 = new Player("Player2", new PlayingPiece(PieceType.O));

            _players.Add(player1);
            _players.Add(player2);

            _board = new Board(3);
        }

        internal string StartGame()
        {
            bool noWinner = true;
            while (noWinner)
            {
                //get the free spaces
                var freeSpaces = _board.GetFreeSpaces();
                if(freeSpaces.Count == 0)
                {
                    noWinner = false; 
                    continue;
                }
                var playerTurn = _players[0];
                _board.PrintBoard();

                Console.Write("Player: " + playerTurn.Name + " Enter row, column: ");
                var input =  Console.ReadLine().Split(',');

                int row = int.Parse(input[0]);
                int col = int.Parse(input[1]);

                //place the row col of player1 to board
                bool isSuccess = _board.AddSymbol(row, col, playerTurn);
                if (!isSuccess)
                {
                    Console.WriteLine("Incorrect position chosen, try again");
                    continue;
                }
                _players.RemoveAt(0);
                _players.Add(playerTurn);

                bool winner = CheckForWinner(row, col, playerTurn.PlayingPiece.PieceType);

                if (winner)
                {
                    return playerTurn.Name;
                }
            }
            return "Tie";
        }

        private bool CheckForWinner(int row, int col, PieceType pieceType)
        {
            bool rowMatch = true;
            bool colMatch = true;
            bool diagMatch = true;
            bool revDiagMatch = true;

            for (int i = 0, j = _board.Size - 1; i < _board.Size; i++,j--)
            {
                //need to check in row
                if (_board.GameBoard[row][i] == null || _board.GameBoard[row][i].PieceType != pieceType)
                {
                    rowMatch = false;
                }
                //need to check in column
                if (_board.GameBoard[i][col] == null || _board.GameBoard[i][col].PieceType != pieceType)
                {
                    colMatch = false;
                }
                //need to check diagonals
                if (_board.GameBoard[i][i] == null || _board.GameBoard[i][i].PieceType != pieceType)
                {
                    diagMatch = false;
                }
                //need to check anti-diagonals
                if (_board.GameBoard[i][j] == null || _board.GameBoard[i][j].PieceType != pieceType)
                {
                    revDiagMatch = false;
                }
            }

            return rowMatch || colMatch || diagMatch || revDiagMatch;

        }
    }
}
