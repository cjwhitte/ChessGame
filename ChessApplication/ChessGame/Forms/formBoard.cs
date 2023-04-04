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

        private int xValue, yValue;

        private void TextBoxX_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(TextBoxX.Text, out xValue);
        }

        private void TextBoxY_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(TextBoxY.Text, out yValue);
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            LabelX.Text = xValue.ToString();
            LabelY.Text = yValue.ToString();

            board.CompareSquares(xValue, yValue, LabelX, LabelY);
        }
    }
}
