using Microsoft.EntityFrameworkCore;
using System.IO;

namespace MusicApi.Models
{
    public class MusicContext : DbContext
    {
        public string DbPath { get; set; }
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(new Album
            {
                albumId = 1,
                albumName = "Electric Ladyland",
                artistId = 1,
                numberOfSongs = 16,
                releaseDate = new DateOnly(1968, 10, 16),
                albumLength = new TimeOnly(1, 28, 00)

            });
            modelBuilder.Entity<Song>().@HasData(
                new Song
                {
                    songId = 1,
                    songName = "Come on",
                    albumId = 1,
                    artistId = 1,
                    SongLength = new TimeOnly(00, 04, 59)
                });
            modelBuilder.Entity<Artist>().@HasData(
                new Artist
                {
                    artistId = 1,
                    artistName = "Jimi Hendrix",
                    genre = "Rock",
                    hometown = "Seattle Washington",
                    DOB = new DateOnly(1942, 9, 27)

                });
            base.OnModelCreating(modelBuilder);
        }

    }
}
