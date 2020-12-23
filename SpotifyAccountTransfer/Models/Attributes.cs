using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyAccountTransfer.Models
{
    public class Attributes
    {
        public Artwork artwork { get; set; }
        public string artistName { get; set; }
        public int discNumber { get; set; }
        public List<string> genreNames { get; set; }
        public int durationInMillis { get; set; }
        public string releaseDate { get; set; }
        public string name { get; set; }
        public bool hasLyrics { get; set; }
        public string albumName { get; set; }
        public PlayParams playParams { get; set; }
        public int trackNumber { get; set; }
        public string contentRating { get; set; }
    }
}
