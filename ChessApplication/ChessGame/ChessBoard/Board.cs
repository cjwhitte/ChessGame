using ChessApplication.ChessGame.Enums;
using ChessApplication.ChessGame.Pieces;
using ChessApplication.ChessGame.Structs;


namespace ChessApplication.ChessGame.ChessBoard
{
    internal class Board
    {

        private Move CurrentMove;


        List<Piece> WhitePieces;
        List<Piece> BlackPieces;
        private FlowLayoutPanel FlowLayoutPanel;
        public Square[,] Squares;
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
        public Board(FlowLayoutPanel flowLayoutPanel)
        {
            Squares = new Square[8, 8];
            FlowLayoutPanel = flowLayoutPanel;
            CreateBoard();
        }



        public void CreateBoard()
        {
            InstantiateSquares();
            // Parse FEN String
            RenderSquares();
            InstantiatePieces();
        }

        #region Instantiation

        private int SquareSize = 50;
        private void InstantiatePieces()
        {
            WhitePieces = new List<Piece>();
            BlackPieces = new List<Piece>();



            foreach (Panel panel in FlowLayoutPanel.Controls)
            {
                if (panel.Tag == null) return;

                string tag = panel.Tag.ToString();

                Label Piece = new Label
                {
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Size = new Size(50, 50),
                    Tag = panel.Tag.ToString()
                };

                Piece.Click += new EventHandler(Piece_Click);

                #region Insert Images And Create Pieces

                Colours white = Colours.White;
                Colours black = Colours.Black;

                // Pawns
                if (tag.Contains('2'))
                    WhitePieces.Add(new Pawn(tag, Piece, white));


                else if (tag.Contains('7'))
                    BlackPieces.Add(new Pawn(tag, Piece, black));

                // Rooks
                else if (tag == "a1" || tag == "h1")
                    WhitePieces.Add(new Rook(tag, Piece, white));
                else if (tag == "a8" || tag == "h8")
                {
                    BlackPieces.Add(new Rook(tag, Piece, black));
                }

                // Bishops
                else if (tag == "c1" || tag == "f1")
                {
                    WhitePieces.Add(new Bishop(tag, Piece, white));
                }
                else if (tag == "c8" || tag == "f8")
                {
                    BlackPieces.Add(new Bishop(tag, Piece, black));
                }

                // Knights
                else if (tag == "b1" || tag == "g1")
                {
                    WhitePieces.Add(new Knight(tag, Piece, white));
                }
                else if (tag == "b8" || tag == "g8")
                {
                    BlackPieces.Add(new Knight(tag, Piece, black));
                }

                // Queens
                else if (tag == "d1")
                {
                    WhitePieces.Add(new Queen(tag, Piece, white));
                }
                else if (tag == "d8")
                {
                    BlackPieces.Add(new Queen(tag, Piece, black));
                }

                // Kings
                else if (tag == "e1")
                {
                    WhitePieces.Add(new King(tag, Piece, white));
                }
                else if (tag == "e8")
                {
                    BlackPieces.Add(new King(tag, Piece, black));
                }

                #endregion

                panel.Controls.Add(Piece);

            }
        }
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

            var ColourLight = Color.White;
            var ColourDark = Color.Brown;

            for (int i = GRIDSIZE; i > 0; i--)
            {
                for (int j = 1; j < GRIDSIZE + 1; j++)
                {
                    var newPanel = new Panel
                    {
                        Size = new Size(SQUARESIZE, SQUARESIZE),
                        Location = new Point(SQUARESIZE * i, SQUARESIZE * j),
                        Margin = new Padding(0, 0, 0, 0),
                        AutoSize = false,
                        Tag = $"{Notation[j]}{i}"

                    };

                    FlowLayoutPanel.Controls.Add(newPanel);


                    if (i % 2 == 0)
                        newPanel.BackColor = j % 2 != 0 ? ColourLight : ColourDark;
                    else
                        newPanel.BackColor = j % 2 != 0 ? ColourDark : ColourLight;


                }
            }
        }


        #endregion

        void Piece_Click(object sender, EventArgs e)
        {
            // White or Black
            Label label = sender as Label;

            if (label == null) return;

            if (CurrentMove.startingLocation == null)
            {
                foreach (Piece piece in WhitePieces)
                {
                    if (piece.Notation == label.Tag.ToString())
                    {
                        Panel panel = GetRelativePanel(label);

                        CurrentMove = new Move(panel.Tag.ToString());
                    }
                }
            }

            else
            {
                foreach (Piece piece in WhitePieces)
                {
                    Panel panel = GetRelativePanel(label);

                    if (panel.Tag.ToString() != CurrentMove.startingLocation)
                    {
                        CurrentMove.endingLocation = panel.Tag.ToString();
                        if (piece.Notation == CurrentMove.startingLocation)
                        {
                            // Search for label of ending Location
                            piece.CreateMove(CurrentMove, FlowLayoutPanel);
                        }

                    }
                }
                CurrentMove = new Move();
            }
        }
        private Panel GetRelativePanel(Label label)
        {
            foreach (Panel panel in FlowLayoutPanel.Controls)
            {
                if (panel.Tag.ToString() == label.Tag.ToString())
                    return panel;
            }
            return new Panel();
        }
    }
}
