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
            board = new Board(this);
        }

        private int xValue = 0;
        private int yValue = 0;

        private void UpButton_Click(object sender, EventArgs e)
        {
            yValue -= 50;
            Compare();

        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            xValue -= 50;
            Compare();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            xValue += 50;
            Compare();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            yValue += 50;
            Compare();
        }

        private void Compare()
        {

            board.CompareSquares(xValue, yValue, LabelX, LabelY);
        }




        // LabelX.Text = xValue.ToString();
        // LabelY.Text = yValue.ToString();


    }
}
