using ChessApplication.ChessGame.Enums;
using ChessApplication.ChessGame.Structs;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Piece
    {
        public void Move(Move move)
        {

        }
        public Piece() { NumberMoves = new List<Move>(); PossibleMoves = new List<Move>(); }
        public Location location { get; set; }
        public Colours colour { get; set; }
        public List<Move> NumberMoves { get; set; }
        public List<Move> PossibleMoves { get; set; }
        public char? PieceNotation { get; set; }
    }
}
