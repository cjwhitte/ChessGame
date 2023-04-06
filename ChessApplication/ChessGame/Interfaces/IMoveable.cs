using ChessApplication.ChessGame.Structs;

namespace ChessApplication.ChessGame.Interfaces
{
    internal interface IMoveable
    {
        void Move(Move move);
        List<Move> CalculateMoves(string StartingLocation, FlowLayoutPanel flow);
    }
}
