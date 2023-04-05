using ChessApplication.ChessGame.Enums;
using ChessApplication.ChessGame.Interfaces;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Rook : Piece, IMoveable
    {
        public Rook(string Notation, Label PiecePosition, Colours Colour)
        {
            this.Notation = Notation;
            Name = "Rook";
            this.PiecePosition = PiecePosition;

            ReadInImages();

            if (Colour == Colours.White)
                this.PiecePosition.Image = WhiteImage;
            else
                this.PiecePosition.Image = BlackImage;
        }
        public void CalculateMoves()
        {

        }

        private void ReadInImages()
        {
            WhiteImage = System.Drawing.Image.FromFile(@"C:\\Users\\HP Sauce\\Documents\\GitHub\\ChessGame\\ChessApplication\\Resources\\White Pieces\\WhiteRook.png");
            BlackImage = System.Drawing.Image.FromFile(@"C:\\Users\\HP Sauce\\Documents\\GitHub\\ChessGame\\ChessApplication\\Resources\\Black Pieces\\BlackRook.png");

        }
    }
}
