namespace Business.DDEXSchemaERN_382.Entities
{
    public class TrackModel
    {
        // track release
        public int Ordinal { get; set; }
        public string ISRC { get; set; }
        public string Title { get; set; }

        // soundrecording
        public string Genre { get; set; }
        public string SubGenre { get; set; }
    }
}
