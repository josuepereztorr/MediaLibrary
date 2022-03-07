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
            };

            movie.Display();
            
            Logger.Info("Program Ended");
        }
    }
}
