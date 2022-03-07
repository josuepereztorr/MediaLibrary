using System;
using System.IO;
using NLog;

namespace MediaLibrary
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Logger.Info("Program Started");

            Movie movie = new Movie
            {
                MediaId = 123,
                Title = "Greatest Movie Ever, The (2020)",
                Genres = {"Comedy", "Romance"},
                Director = "Jeff Grissom",
                RunningTime = new TimeSpan(2, 21, 23),
            };

            movie.Display();
            
            Album album = new Album
            {
                MediaId = 321,
                Title = "Greatest Album Ever, The (2020)",
                Artist = "Jeff's Awesome Band",
                RecordLabel = "Universal Music Group",
                Genres = { "Rock" }
            };
            Console.WriteLine(album.Display());

            Logger.Info("Program Ended");
        }
    }
}
