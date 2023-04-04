using ChessApplication.ChessGame.Forms;

namespace ChessApplication.ChessGame
{
    public partial class formMainMenu : Form
    {
        public formMainMenu()
        {
            InitializeComponent();
        }

        private void ChessLabel_Click(object sender, EventArgs e)
        {
            // New Form Chess Board
            this.Visible = false;
            var FormBoard = new formBoard();
            FormBoard.Show();
        }
    }
}
