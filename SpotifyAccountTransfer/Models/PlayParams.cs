using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyAccountTransfer.Models
{
    public class PlayParams
    {
        public string id { get; set; }
        public string kind { get; set; }
        public bool isLibrary { get; set; }
        public bool reporting { get; set; }
        public string catalogId { get; set; }
    }
}
