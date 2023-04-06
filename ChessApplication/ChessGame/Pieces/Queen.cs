using ChessApplication.ChessGame.Enums;
using ChessApplication.ChessGame.Interfaces;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Queen : Piece, IMoveable
    {
        public Queen(string Notation, Label PiecePosition, Colours Colour)
        {
            this.Notation = Notation;
            Name = "Queen";
            this.PiecePosition = PiecePosition;
            this.Colour = Colour;

            ReadInImages();

            if (Colour == Colours.White)
                this.PiecePosition.Image = WhiteImage;
            else
                this.PiecePosition.Image = BlackImage;
        }


        private void ReadInImages()
        {
            WhiteImage = System.Drawing.Image.FromFile(@"C:\\Users\\HP Sauce\\Documents\\GitHub\\ChessGame\\ChessApplication\\Resources\\White Pieces\\WhiteQueen.png");
            BlackImage = System.Drawing.Image.FromFile(@"C:\\Users\\HP Sauce\\Documents\\GitHub\\ChessGame\\ChessApplication\\Resources\\Black Pieces\\BlackQueen.png");

        }
    }
}
