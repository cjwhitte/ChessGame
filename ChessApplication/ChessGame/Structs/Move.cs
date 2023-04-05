namespace ChessApplication.ChessGame.Structs
{
    public struct Move
    {
        public Move(string startingLocation)
        {
            this.startingLocation = startingLocation;
            this.endingLocation = null;
        }

        public Move(string startingLocation, string endingLocation)
        {
            this.startingLocation = startingLocation;
            this.endingLocation = endingLocation;
        }

        public string? startingLocation { get; set; }

        public string? endingLocation { get; set; }
    }
}
