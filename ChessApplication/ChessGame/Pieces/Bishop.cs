using ChessApplication.ChessGame.Interfaces;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Bishop : Piece, IMoveable
    {
        public Bishop()
        {
            PieceNotation = 'B';
        }
        public void CalculateMoves()
        {

        }
    }
}
