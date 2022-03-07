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
            
            string scrubbedFile = FileScrubber.ScrubMovies("movies.csv");
            Logger.Info(scrubbedFile);
            
            Logger.Info("Program Ended");
        }
    }
}
