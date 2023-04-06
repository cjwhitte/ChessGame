using ChessApplication.ChessGame.ChessBoard;

namespace ChessApplication.ChessGame.Forms
{
    public partial class formBoard : Form
    {
        public int squareSize = 40;
        Board board;
        public formBoard()
        {
            this.Controls.Add(label1);
            InitializeComponent();
            board = new Board(this.flowLayoutPanel, label1);
        }
    }
}
