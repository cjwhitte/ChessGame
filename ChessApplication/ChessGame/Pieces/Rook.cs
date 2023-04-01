using ChessApplication.ChessGame.Interfaces;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Rook : Piece, IMoveable
    {
        public Rook()
        {
            PieceNotation = 'R';
        }
        public void CalculateMoves()
        {

        }
    }
}
