using ChessApplication.ChessGame.Interfaces;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Pawn : Piece, IMoveable
    {
        public Pawn()
        {
            PieceNotation = null;
        }
        public void CalculateMoves()
        {

        }
    }
}
