using ChessApplication.ChessGame.Enums;
using ChessApplication.ChessGame.Structs;

namespace ChessApplication.ChessGame.Pieces
{
    internal class Piece
    {
        public void CreateMove(Move move, FlowLayoutPanel flow)
        {
            squares = flow;
            RemoveOldImage();
            
            Move(move);
            ChooseImage();
            // PiecePosition.Image = null;

        }

        private void RemoveOldImage()
        {
            Panel? panel = GetRelativePanel();
            foreach(Label label in panel.Controls)
            {
                label.Image = null;
            }
        }

        private Panel? GetRelativePanel()
        {
            foreach(Panel panel in squares.Controls)
            {
                if (panel.Tag.ToString() == Notation)
                    return panel;
            }
            return null;
        }


        public void Move(Move move)
        {
            Notation = move.endingLocation;
            Moves.Add(move);
        }


        #region Change Image Types
        private void ChooseImage()
        {
            if (colour == Colours.White)
                ChangeWhiteImage();
            else
                ChangeBlackImage();

        }
        private void ChangeWhiteImage()
        {
            foreach (Panel panel in squares.Controls)
            {
                if (panel.Tag.ToString() == Notation)
                {
                    foreach (Label control in panel.Controls)
                    {
                        control.Image = WhiteImage;
                    }
                }
            }
        }

        private void ChangeBlackImage()
        {
            foreach (Panel panel in squares.Controls)
            {
                if (panel.Tag.ToString() == Notation)
                {
                    foreach (Label control in panel.Controls)
                    {
                        control.Image = BlackImage;
                    }
                }
            }
        }
        #endregion


        private FlowLayoutPanel squares;

        public Label PiecePosition;
        public System.Drawing.Image WhiteImage;
        public System.Drawing.Image BlackImage;
        public Piece() { Moves = new List<Move>(); PossibleMoves = new List<Move>(); }
        public Colours colour { get; set; }
        public string Notation { get; set; }
        public List<Move> Moves { get; set; }
        public List<Move> PossibleMoves { get; set; }
        public string Name;
    }
}
