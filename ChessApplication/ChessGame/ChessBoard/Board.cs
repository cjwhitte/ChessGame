using ChessApplication.ChessGame.Structs;
using static System.Net.Mime.MediaTypeNames;


namespace ChessApplication.ChessGame.ChessBoard
{
    internal class Board
    {
        // Change list to array of squares
        public Square[,] Squares;
        private FlowLayoutPanel FlowLayoutPanel;
        public Board(FlowLayoutPanel panel)
        {
            Squares = new Square[8, 8];
            FlowLayoutPanel = panel;
            
            CreateBoard();

        }

        public void CreateBoard()
        {
            InstantiateSquares();
            // Parse FEN String
            RenderSquares();
            InstantiatePieces();
        }

        #region Instantiate Pieces

        private void InstantiatePieces()
        {
            foreach(Panel panel in FlowLayoutPanel.Controls)
            {
                if (panel.Tag == null) return;
                Label text = new Label
                {
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Size = new Size(50,50)
                };
                if (panel.Tag.ToString().Contains('2') || panel.Tag.ToString().Contains('7')) text.Text = "P";

                else if (panel.Tag.ToString() == "a1" || panel.Tag.ToString() == "h1") text.Text = "R";
                else if (panel.Tag.ToString() == "a8" || panel.Tag.ToString() == "h8") text.Text = "R";

                else if (panel.Tag.ToString() == "c1" || panel.Tag.ToString() == "f1") text.Text = "B";
                else if (panel.Tag.ToString() == "c8" || panel.Tag.ToString() == "f8") text.Text = "B";

                else if (panel.Tag.ToString() == "b1" || panel.Tag.ToString() == "g1") text.Text = "N";
                else if (panel.Tag.ToString() == "b8" || panel.Tag.ToString() == "g8") text.Text = "N";

                else if (panel.Tag.ToString() == "d1") text.Text = "Q";
                else if (panel.Tag.ToString() == "d8") text.Text = "Q";

                else if (panel.Tag.ToString() == "e1") text.Text = "K";
                else if (panel.Tag.ToString() == "e8") text.Text = "K";


                panel.Controls.Add(text);
            }
        }


        #endregion

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


        #region Render Squares

        private const int SQUARESIZE = 50;
        private const int GRIDSIZE = 8;
        public void RenderSquares()
        {

            var ColourWhite = Color.White;
            var ColourBlack = Color.Black;

            for (int i = GRIDSIZE; i > 0; i--)
            {
                for (int j = 1; j < GRIDSIZE + 1; j++)
                {
                    var newPanel = new Panel
                    {
                        Size = new Size(SQUARESIZE, SQUARESIZE),
                        Location = new Point(SQUARESIZE * i, SQUARESIZE * j),
                        Margin = new Padding(0,0,0,0),
                        AutoSize = false,
                        Tag = $"{Notation[j]}{i}"

                    };

                    FlowLayoutPanel.Controls.Add(newPanel);
                    

                    if (i % 2 == 0)
                        newPanel.BackColor = j % 2 != 0 ? Color.LightPink : Color.DarkSlateGray;
                    else
                        newPanel.BackColor = j % 2 != 0 ? Color.DarkSlateGray : Color.LightPink;


                }
            }
        }


        #endregion

        private Dictionary<int, char> Notation = new Dictionary<int, char>()
            {

                { 1 , 'a' },
                { 2, 'b' },
                { 3, 'c' },
                { 4, 'd' },
                { 5, 'e' },
                { 6, 'f' },
                { 7, 'g' },
                { 8, 'h' }
            };

        #region Square Utilites
        public void CompareSquares(int xVal, int yVal, Label textX, Label textY)
        {

            #region errors
            if (xVal < 0 || xVal > 350)
            {
                textX.Text = "Incorrect Range";
                return;
            }
            if (yVal < 0 || yVal > 350)
            {
                textY.Text = "Incorrect Range";
                return;
            }

            if (xVal % 50 != 0)
            {
                textX.Text = "Incorrect Value";
                return;
            }
            if (yVal % 50 != 0)
            {
                textY.Text = "Incorrect Value";
                return;
            }
            #endregion

            foreach(Panel panel in FlowLayoutPanel.Controls)
            {
                if((string)panel.Tag == $"{Notation[(xVal / 50) + 1]}{(yVal / 50) + 1}")
                {
                    panel.BackColor = Color.Green;
                    var label = new Label
                    {
                        Text = "P",
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Size = new Size(50,50)
                    };
                    panel.Controls.Add(label);
                }
                
            }







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
