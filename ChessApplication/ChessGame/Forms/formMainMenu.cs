using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessApplication.ChessGame.ChessBoard;

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
            new Board();
            this.Visible = false;
        }
    }
}
