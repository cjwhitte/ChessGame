namespace ChessApplication.ChessGame.Structs
{
    public struct Move
    {
        public Move(Location startingLocation, Location endingLocation)
        {
            this.startingLocation = startingLocation;
            this.endingLocation = endingLocation;
        }

        public Location startingLocation { get; set; }

        public Location endingLocation { get; set; }
    }
}
