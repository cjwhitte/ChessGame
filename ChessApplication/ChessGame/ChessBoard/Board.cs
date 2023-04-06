using ChessApplication.ChessGame.Enums;
using ChessApplication.ChessGame.Pieces;
using ChessApplication.ChessGame.Structs;


namespace ChessApplication.ChessGame.ChessBoard
{
    internal class Board
    {

        public static Colours turn;

        private Move WhiteCurrentMove;
        private Move BlackCurrentMove;

        private List<Move> WhitePossibleMoves;
        private List<Move> BlackPossibleMoves;


        List<Piece> WhitePieces;
        List<Piece> BlackPieces;
        private FlowLayoutPanel FlowLayoutPanel;
        public Square[,] Squares;
        private Label lab;
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
        public Board(FlowLayoutPanel flowLayoutPanel, Label lab)
        {
            this.lab = lab;
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

                Label PieceLabel = new Label
                {
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Size = new Size(50, 50),
                    Tag = tag
                };


                lab.Size = new Size(100, 100);

                #region Create Pieces

                Colours white = Colours.White;
                Colours black = Colours.Black;

                // Pawns
                if (tag.Contains('2'))
                    WhitePieces.Add(new Pawn(tag, PieceLabel, white));


                else if (tag.Contains('7'))
                    BlackPieces.Add(new Pawn(tag, PieceLabel, black));

                // Rooks
                else if (tag == "a1" || tag == "h1")
                    WhitePieces.Add(new Rook(tag, PieceLabel, white));
                else if (tag == "a8" || tag == "h8")
                {
                    BlackPieces.Add(new Rook(tag, PieceLabel, black));
                }

                // Bishops
                else if (tag == "c1" || tag == "f1")
                {
                    WhitePieces.Add(new Bishop(tag, PieceLabel, white));
                }
                else if (tag == "c8" || tag == "f8")
                {
                    BlackPieces.Add(new Bishop(tag, PieceLabel, black));
                }

                // Knights
                else if (tag == "b1" || tag == "g1")
                {
                    WhitePieces.Add(new Knight(tag, PieceLabel, white));
                }
                else if (tag == "b8" || tag == "g8")
                {
                    BlackPieces.Add(new Knight(tag, PieceLabel, black));
                }

                // Queens
                else if (tag == "d1")
                {
                    WhitePieces.Add(new Queen(tag, PieceLabel, white));
                }
                else if (tag == "d8")
                {
                    BlackPieces.Add(new Queen(tag, PieceLabel, black));
                }

                // Kings
                else if (tag == "e1")
                {
                    WhitePieces.Add(new King(tag, PieceLabel, white));
                }
                else if (tag == "e8")
                {
                    BlackPieces.Add(new King(tag, PieceLabel, black));
                }

                #endregion

                panel.Controls.Add(PieceLabel);

                Piece selectedPiece = LookForPieces(panel.Tag.ToString());




                if (selectedPiece == null)
                {
                    lab.Text = $"null";
                panel.Click += new EventHandler(UnoccupiedSquare_Click);

                }

                else if (selectedPiece.Colour == Colours.White)
                {
                    panel.Click += new EventHandler(WhitePiece_Click);
                lab.Text = $"{selectedPiece}";

                }
                else if (selectedPiece.Colour == Colours.Black)
                    panel.Click += new EventHandler(BlackPiece_Click);


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

        void WhitePiece_Click(object sender, EventArgs e)
        {

            // White or Black
            Label label = sender as Label;

            if (label == null) return;

            if (WhiteCurrentMove.startingLocation == null)
            {
                Panel panel = GetRelativePanel(label);
                lab.Text = $"{lab.Text}\n WHITE PIECE";
                WhiteCurrentMove = new Move(panel.Tag.ToString());
                panel.BackColor = Color.Green;
            }

            else
            {
                
                
            }


        }
        void BlackPiece_Click(object sender, EventArgs e)
        {
            #region Error Handling
            // White or Black
            Label label = sender as Label;

            if (label == null) return;
            #endregion

            // If black hasnt made a move yet
            if (BlackCurrentMove.startingLocation == null)
            {
                Panel panel = GetRelativePanel(label);
                lab.Text = $"{lab.Text}\n BLACK PIECE";

                BlackCurrentMove = new Move(panel.Tag.ToString());
            }

            // Black has selected their piece
            else
            {
                // if piece is white, capture 
                // if piece is black, dont allow move
            }
        }
        void UnoccupiedSquare_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label == null) return;

            Piece piece = new Piece();
            
            // Calculate Moves

            // Loop through all pieces and find correct Piece
            foreach(Piece WhitePiece in WhitePieces)
            {
                foreach(Piece BlackPiece in BlackPieces)
                {
                    if(WhitePiece.Notation == WhiteCurrentMove.startingLocation)
                    {
                        piece = WhitePiece;
                        WhitePossibleMoves = piece.CalculateMoves(piece.Notation, FlowLayoutPanel);
                    }
                    else if(BlackPiece.Notation == BlackCurrentMove.startingLocation)
                    {
                        piece = BlackPiece;
                        BlackPossibleMoves = piece.CalculateMoves(piece.Notation, FlowLayoutPanel);
                    }
                }
            }




            // Get position of Label
            // Check if move is possible
            // call CreateMove() on piece
            lab.Text = $"Moving Piece [{piece.Name},{piece.Notation}] to {label.Tag.ToString()}";

            foreach(Move move in WhitePossibleMoves.Concat(BlackPossibleMoves))
            {
                if(move.endingLocation == label.Tag.ToString())
                {
                    piece.CreateMove(move, FlowLayoutPanel);
                    lab.Text = "Moved Piece";
                    break;
                }
            }

            BlackCurrentMove = new Move();
            WhiteCurrentMove = new Move();




        }

        private Piece? LookForPieces(string TargetNotation)
        {
            foreach (Piece piece in WhitePieces)
            {
                if (piece.Notation == TargetNotation)
                    return piece;
            }
            foreach(Piece piece in BlackPieces)
            {
                if(piece.Notation == TargetNotation)
                    return piece;
            }

            return null;
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
