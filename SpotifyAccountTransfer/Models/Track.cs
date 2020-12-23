using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyAccountTransfer.Models
{
    public class Track
    {
        public string id { get; set; }
        public string type { get; set; }
        public string href { get; set; }
        public Attributes attributes { get; set; }
    }
}
