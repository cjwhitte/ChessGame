using ChessApplication.ChessGame.Interfaces;

namespace ChessApplication.ChessGame.Pieces
{
    internal class King : Piece, IMoveable
    {
        public King()
        {
            PieceNotation = 'K';
        }
        public void CalculateMoves()
        {

        }
    }
}
