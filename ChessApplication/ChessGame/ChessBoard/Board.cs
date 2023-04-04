using ChessApplication.ChessGame.Structs;


namespace ChessApplication.ChessGame.ChessBoard
{
    internal class Board
    {
        // Change list to array of squares
        public Square[,] Squares;
        private Form FormBoard;
        public Board(Form form)
        {
            Squares = new Square[8, 8];
            FormBoard = form;
            _chessBoardPanels = new Panel[GRIDSIZE, GRIDSIZE];
            CreateBoard();

        }

        public void CreateBoard()
        {
            InstantiateSquares();
            // Instantiate Pieces
            RenderSquares();
        }

        #region Instantiate Squares

        private int SquareSize = 50;
        private void InstantiateSquares()
        {
            int SquareNumber = 1;
            foreach (var i in Enumerable.Range(0, Squares.GetLength(0)))
            {
                foreach (var j in Enumerable.Range(0, Squares.GetLength(1)))
                {
                    Squares[i, j] = new Square(new Location(i, j), new Point(SquareSize * i, SquareSize * j), SquareNumber);
                    SquareNumber++;
                }
            }
        }
        #endregion

        #region Instantiate Pieces




        #endregion

        #region Render Squares

        private Panel[,] _chessBoardPanels;

        private const int SQUARESIZE = 50;
        private const int GRIDSIZE = 8;
        public void RenderSquares()
        {

            var ColourWhite = Color.White;
            var ColourBlack = Color.Black;

            for (int i = 0; i < GRIDSIZE; i++)
            {
                for (int j = 0; j < GRIDSIZE; j++)
                {
                    var newPanel = new Panel
                    {
                        Size = new Size(SQUARESIZE, SQUARESIZE),
                        Location = new Point(SQUARESIZE * i, SQUARESIZE * j)
                    };

                    newPanel.AutoSize = false;

                    FormBoard.Controls.Add(newPanel);

                    _chessBoardPanels[i, j] = newPanel;

                    if (i % 2 == 0)
                        newPanel.BackColor = j % 2 != 0 ? ColourWhite : ColourBlack;
                    else
                        newPanel.BackColor = j % 2 != 0 ? ColourBlack : ColourWhite;


                }
            }
        }


        #endregion

        #region Square Utilites
        public void CompareSquares(int xVal, int yVal, Label textX, Label textY)
        {

            // Handle Errors

            if(xVal < 0 || xVal > 350)
            {
                textX.Text = "Incorrect Range";
                return;
            }
            if (yVal < 0 || yVal > 350)
            {
                textY.Text = "Incorrect Range";
                return;
            }

            if(xVal % 50 != 0)
            {
                textX.Text = "Incorrect Value";
                return;
            }
            if(yVal % 50 != 0)
            {
                textY.Text = "Incorrect Value";
                return;
            }





            for (var i = 0; i < Squares.GetLength(0); i++)
            {
                for (var j = 0; j < Squares.GetLength(1); j++)
                {
                    if (GetSquare(new Point(xVal, yVal)).Point == _chessBoardPanels[i, j].Location)
                    {
                        _chessBoardPanels[i, j].BackColor = Color.Green;
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {

                            _chessBoardPanels[i, j].BackColor = j % 2 != 0 ? Color.White : Color.Black;
                        }
                        else
                        {
                            _chessBoardPanels[i, j].BackColor = j % 2 != 0 ? Color.Black : Color.White;
                        }
                    }
                }
            }
        }

        private void LoopSquares()
        {

            string res = "";
            for (var i = 0; i < Squares.GetLength(0); i++)
            {
                for (var j = 0; j < Squares.GetLength(1); j++)
                {
                    res = $"{res} [{Squares[i, j].Point}], ";
                }
            }

            Label label = new Label
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = res,
                Size = new Size(1000, 1000)
            };

            FormBoard.Controls.Add(label);
        }
        private Square GetSquare(Point point)
        {
            return SearchSqaures(point);

        }

        private Square? SearchSqaures(Point point)
        {
            for (var i = 0; i < Squares.GetLength(0); i++)
            {
                for (var j = 0; j < Squares.GetLength(1); j++)
                {
                    if (Squares[i, j].Point == point)
                    {
                        return Squares[i, j];
                    }
                }
            }

            return null;

        }

        #endregion

    }
}
