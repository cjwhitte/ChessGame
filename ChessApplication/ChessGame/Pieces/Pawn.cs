using ChessApplication.ChessGame.Enums;
using ChessApplication.ChessGame.Interfaces;
using ChessApplication.ChessGame.Structs;
using ChessApplication.ChessGame.Utilities;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Pawn : Piece, IMoveable
    {
        public Pawn(string Notation, Label PiecePosition, Colours Colour)
        {
            this.Notation = Notation;
            Name = "Pawn";
            this.PiecePosition = PiecePosition;

            ReadInImages();

            if (Colour == Colours.White)
                this.PiecePosition.Image = WhiteImage;
            else
                this.PiecePosition.Image = BlackImage;
        }
        public void CalculateMoves()
        {
            Location location = this.Notation.ToLocation();
            location.x = location.x++;
            PossibleMoves.Add(new Move(location.ToNotation()));

        }

        
        private void ReadInImages()
        {
            WhiteImage = System.Drawing.Image.FromFile(@"C:\\Users\\HP Sauce\\Documents\\GitHub\\ChessGame\\ChessApplication\\Resources\\White Pieces\\WhitePawn.png");
            BlackImage = System.Drawing.Image.FromFile(@"C:\\Users\\HP Sauce\\Documents\\GitHub\\ChessGame\\ChessApplication\\Resources\\Black Pieces\\BlackPawn.png");

        }
    }
}
