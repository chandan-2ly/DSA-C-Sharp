namespace TicTakToe
{
    internal class PlayingPiece
    {
        public PieceType PieceType { get; set; }

        public PlayingPiece(PieceType pieceType)
        {
            PieceType = pieceType;
        }
    }
}
