﻿using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models
{
    public class Album
    {
        [Key]
        public int albumId { get; set; }
        [MaxLength(100)]
        public string albumName { get; set; }
        public int artistId { get; set; }
        public int numberOfSongs { get; set; }
        public DateOnly releaseDate { get; set; }

        public TimeOnly albumLength { get; set; }

    }
}
