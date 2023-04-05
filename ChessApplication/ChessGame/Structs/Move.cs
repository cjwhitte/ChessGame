namespace ChessApplication.ChessGame.Structs
{
    public struct Move
    {
        public Move(string startingLocation)
        {
            this.startingLocation = startingLocation;
            this.endingLocation = null;
        }

        public string? startingLocation { get; set; }

        public string? endingLocation { get; set; }
    }
}
