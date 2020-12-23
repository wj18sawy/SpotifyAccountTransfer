using Microsoft.Extensions.Configuration;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;

namespace SpotifyAccountTransfer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the development branch.");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            // Apple Music




            // Spotify
            
            string token = config["Token"];
            SpotifyClient spotify = new SpotifyClient(token);

            SearchRequest request = new SearchRequest(SearchRequest.Types.Track, "Caroline Neil Diamond");
            SearchClient client = (SearchClient)spotify.Search;
            SearchResponse response = client.Item(request).Result;


            string trackId = response.Tracks.Items[0].Id;

            LibrarySaveTracksRequest saveRequest = new LibrarySaveTracksRequest(new List<string> { trackId });
            var a = spotify.Library.SaveTracks(saveRequest).Result;
            Console.WriteLine(a);
        }      
    }
}
