using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SpotifyAccountTransfer.Models;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.IO;

namespace SpotifyAccountTransfer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Set up configuration

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            // Get song library from json

            using FileStream stream = File.OpenRead("./AllSongs.json");
            using StreamReader reader = new StreamReader(stream);
            List<Track> appleLibrary = JsonConvert.DeserializeObject<List<Track>>(reader.ReadToEnd());

            // Spotify client
            
            string token = config["Token"];
            SpotifyClient spotify = new SpotifyClient(token);

            // Create search string



            // can only remove 50 tracks at a time, and have to remove them by id so lets make a list of all the files im going to add with their ids
            // incase something goes wrong
            //LibraryRemoveTracksRequest req2 = new LibraryRemoveTracksRequest()
            //spotify.Library.RemoveTracks()

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
