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
            
            Book book = new Book
            {
                MediaId = 111,
                Title = "Super Cool Book",
                Author = "Jeff Grissom",
                PageCount = 101,
                Publisher = "",
                Genres = { "Suspense", "Mystery" }
            };
            Console.WriteLine(book.Display());


            Logger.Info("Program Ended");
        }
    }
}
