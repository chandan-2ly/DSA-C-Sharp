using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTakToe
{
    internal class Board
    {
        public int Size { get; set; }
        public PlayingPiece[][] GameBoard { get; set; }

        public Board(int size)
        {
            Size = size;
            this.GameBoard = new PlayingPiece[Size][];

            for(int i = 0; i < size; i++)
            {
                GameBoard[i] = new PlayingPiece[size];
            }
        }

        internal void PrintBoard()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (GameBoard[i][j] != null)
                    {
                        Console.Write(GameBoard[i][j].PieceType.ToString() + "   ");
                    }
                    else
                    {
                        Console.Write("    ");

                    }
                    Console.Write(" | ");
                }
                Console.WriteLine();

            }

        }

        internal List<(int, int)> GetFreeSpaces()
        {
            List<(int row, int col)> rowCol = new List<(int row, int col)>();

            for(int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    if(GameBoard[i][j] == null)
                    {
                        rowCol.Add((i, j));
                    }
                }
            }

            return rowCol;
        }

        internal bool AddSymbol(int row, int col, Player playerTurn)
        {
            if (GameBoard[row][col] != null)
                return false;

            GameBoard[row][col] = playerTurn.PlayingPiece;
            return true;
        }
    }
}
