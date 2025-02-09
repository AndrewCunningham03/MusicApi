using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models
{
    public class AlbumDto
    {
        public int albumId { get; set; }
        public string albumName { get; set; }
        public int artistId { get; set; }
        public int numberOfSongs { get; set; }
        public DateOnly releaseDate { get; set; }

        public TimeOnly albumLength { get; set; }
    }
}
