using System;
using System.Collections.Generic;
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

            MovieFile movieFile = new MovieFile("scrubbed.txt");
            string input; 

            do
            {
                Console.WriteLine("\nMovie Library\n");
                
                Console.WriteLine("1) Add Movie");
                Console.WriteLine("2) Display all Movies");
                Console.WriteLine("(Type 1, 2, or 'Q' to quit)");

                input = Console.ReadLine();

                if (input == "1")
                {
                    Logger.Info("User choice: 1");

                    Movie movie = new Movie();

                    Console.WriteLine("Enter movie title");
                    String title = Console.ReadLine();

                    if (movieFile.IsUniqueTitle(title))
                    {
                        movie.Title = title;
                        List<string> genres = new List<string>();
                        string genre;
                    
                        do
                        {
                            Console.WriteLine("Enter genre (or done to quit)");
                            genre = Console.ReadLine();
                            if (genre != "done")
                            {
                                genres.Add(genre);
                            }
                        } while (genre != "done");

                        movie.Genres = genres;

                        Console.WriteLine("Enter movie director");
                        String director = Console.ReadLine();
                        movie.Director = director;
                    
                        Console.WriteLine("Enter running Time (h:m:s");
                        TimeSpan runningTime = TimeSpan.Parse(Console.ReadLine());
                        movie.RunningTime = runningTime;

                        movieFile.AddMovie(movie);
                    }

                } else if (input == "2")
                {
                    Logger.Info("User choice: 2");

                    Console.WriteLine();

                    movieFile.Movies.ForEach(m => Console.Write($"{m.Display()}\n"));
                    
                }

            } while (input != "Q");
            
            Logger.Info("Program Ended");
        }
    }
}
