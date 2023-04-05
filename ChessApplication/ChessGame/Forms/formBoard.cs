using ChessApplication.ChessGame.ChessBoard;

namespace ChessApplication.ChessGame.Forms
{
    public partial class formBoard : Form
    {
        public int squareSize = 40;
        Board board;
        public formBoard()
        {
            InitializeComponent();
            board = new Board(this.flowLayoutPanel);
        }
    }
}
