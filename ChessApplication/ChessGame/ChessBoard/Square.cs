using ChessApplication.ChessGame.Enums;
using ChessApplication.ChessGame.Structs;

namespace ChessApplication.ChessGame.ChessBoard
{
    internal class Square
    {
        public Point Point { get; set; }
        public Location Location { get; set; }

        public Colours Colour { get; set; }
        public int SquareNumber { get; set; }


        public Square(Location location, int squareNumber) { this.Location = location; this.SquareNumber = squareNumber; }
    }
}
