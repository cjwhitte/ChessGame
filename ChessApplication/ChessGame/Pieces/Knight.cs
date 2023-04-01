using ChessApplication.ChessGame.Interfaces;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Knight : Piece, IMoveable
    {
        public Knight()
        {
            PieceNotation = 'N';
        }
        public void CalculateMoves()
        {

        }
    }
}
