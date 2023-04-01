namespace ChessApplication.ChessGame.Structs
{
    public struct Location
    {
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x { get; set; }
        public int y { get; set; }
    }
}
