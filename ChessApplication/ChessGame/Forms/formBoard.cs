using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApplication.ChessGame.Forms
{
    public partial class formBoard : Form
    {
        public formBoard()
        {
            InitializeComponent();
        }

        #region Render Squares

        private Panel[,] _chessBoardPanels;

        public void RenderSquares()
        {
            const int squareSize = 40;
            const int gridSize = 8;

            var ColourWhite = Color.White;
            var ColourBlack = Color.Black;

            _chessBoardPanels = new Panel[gridSize, gridSize];

            for(int i = 0; i < gridSize; i++)
            {
                for(int j = 0; j < gridSize; j++)
                {
                    var newPanel = new Panel
                    {
                        Size = new Size(squareSize, squareSize),
                        Location = new Point(squareSize * i, squareSize * j)
                    };

                    Controls.Add(newPanel);

                    _chessBoardPanels[i, j] = newPanel;

                    if (i % 2 == 0)
                        newPanel.BackColor = j % 2 != 0 ? ColourWhite : ColourBlack;
                    else
                        newPanel.BackColor = j % 2 != 0 ? ColourBlack : ColourWhite;


                }
            }
        }


        #endregion

    }
}
