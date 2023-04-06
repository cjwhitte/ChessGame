using ChessApplication.ChessGame.Enums;
using ChessApplication.ChessGame.Interfaces;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Bishop : Piece, IMoveable
    {
        public Bishop(string Notation, Label PiecePosition, Colours Colour)
        {
            this.Notation = Notation;
            Name = "Bishop";

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
            WhiteImage = System.Drawing.Image.FromFile(@"C:\\Users\\HP Sauce\\Documents\\GitHub\\ChessGame\\ChessApplication\\Resources\\White Pieces\\WhiteBishop.png");
            BlackImage = System.Drawing.Image.FromFile(@"C:\\Users\\HP Sauce\\Documents\\GitHub\\ChessGame\\ChessApplication\\Resources\\Black Pieces\\BlackBishop.png");

        }
    }
}
