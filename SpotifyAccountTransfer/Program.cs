using Microsoft.Extensions.Configuration;
using SpotifyAPI.Web;
using System;

namespace SpotifyAccountTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the development branch.");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();


            string token = config["Token"];
            var spotify = new SpotifyClient(token);


            var allMyTracks = spotify.Library.GetTracks().Result;
            var track = spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");
            Console.WriteLine(track.Result.Name);
        }
    }
}
