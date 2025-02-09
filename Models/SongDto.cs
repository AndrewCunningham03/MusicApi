using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models
{
    public class SongDto
    {
        public int songId { get; set; }

        public string songName { get; set; }

        public int albumId { get; set; }

        public int artistId { get; set; }

        public TimeOnly SongLength { get; set; }


    }
}
