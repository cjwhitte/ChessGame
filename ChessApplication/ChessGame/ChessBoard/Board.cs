using ChessApplication.ChessGame.Structs;
using ChessApplication.ChessGame.Forms;


namespace ChessApplication.ChessGame.ChessBoard
{
    internal class Board
    {
        // Change list to array of squares
        public List<List<Square>> Squares;
        public Board()
        {
            Squares = new List<List<Square>>();
            CreateBoard();
        }
        public void CreateBoard()
        {
            var FormBoard = new formBoard();
            FormBoard.Show();
            InstantiateSquares();
            FormBoard.RenderSquares();
        }

        #region Instantiate Squares
        private void InstantiateSquares()
        {
            int SquareNumber = 1;
            foreach (var i in Enumerable.Range(0, 7))
            {
                Squares.Add(new List<Square>());
                foreach (var j in Enumerable.Range(0, 7))
                {
                    Squares[i].Add(new Square(new Location(i, j), SquareNumber));
                    SquareNumber++;
                }
            }
        }
        #endregion

        #region Instantiate Pieces




        #endregion

        #region PrintSquares // Debug

        private void PrintSquares()
        {
            string output = "";
            foreach (var i in Enumerable.Range(0, Squares.Count()))
            {
                foreach (var j in Enumerable.Range(0, Squares.Count()))
                {
                    var query = (from list in Squares
                                 from square in list
                                 where square.Location.x == i
                                 select square).FirstOrDefault();

                    var query2 = (from list in Squares
                                  from square in list
                                  where square.Location.y == j
                                  select square).FirstOrDefault();

                    output = $"{output}, Square[{query.Location.x},{query2.Location.y}]";
                }

            }
            // label.Text = output;
        }

        #endregion

    

    }
}
