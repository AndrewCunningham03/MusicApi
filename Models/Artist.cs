namespace MusicApi.Models
{
    public class Artist
    {
        public int artistId { get; set; }
        public string artistName { get; set; }
        public string genre { get; set; }
        public string hometown { get; set; }
        public DateOnly DOB { get; set; }

    }
}
