﻿using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models
{
    public class Artist
    {
        [Key]
        public int artistId { get; set; }
        [MaxLength(100)]
        public string artistName { get; set; }
        public string genre { get; set; }
        public string hometown { get; set; }
        public DateOnly DOB { get; set; }

    }
}
