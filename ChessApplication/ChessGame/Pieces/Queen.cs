using ChessApplication.ChessGame.Interfaces;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Queen : Piece, IMoveable
    {
        public Queen()
        {
            PieceNotation = 'Q';
        }
        public void CalculateMoves()
        {

        }
    }
}
