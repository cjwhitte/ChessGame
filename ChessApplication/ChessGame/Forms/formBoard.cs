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

        private int xValue = 0;
        private int yValue = 0;

        private void UpButton_Click(object sender, EventArgs e)
        {
            yValue += 50;
            if (yValue > 350) yValue = 350;
            Compare();

        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            xValue -= 50;
            if (xValue < 0) xValue = 0;
            Compare();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            xValue += 50;
            if (xValue > 350) xValue = 350;
            Compare();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            yValue -= 50;
            if (yValue < 0) yValue = 0;
            Compare();
        }

        private void Compare()
        {

            board.CompareSquares(xValue, yValue, LabelX, LabelY);
        }
    }
}
