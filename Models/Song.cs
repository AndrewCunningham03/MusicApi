﻿using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models
{
    public class Song
    {
        [Key]
        public int songId { get; set; }
        [MaxLength(100)]
        public string songName { get; set; }

        public int albumId { get; set; }

        public int artistId { get; set; }

        public TimeOnly SongLength { get; set; }
  

    }
}
