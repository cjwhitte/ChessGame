using ChessApplication.ChessGame.Structs;

namespace ChessApplication.ChessGame.Interfaces
{
    internal interface IMoveable
    {
        void Move(Move move);
        void CalculateMoves();
    }
}
