using System;
using System.Collections.Generic;

namespace MediaLibrary
{
    public class Media
    {
        // public properties
        public UInt64 MediaId { get; set; }
        public string Title { get; set; }
        public List<string> Genres { get; set; }

        // constructor
        public Media()
        {
            Genres = new List<string>();
        }

        // public method
        public string Display()
        {
            return $"Id: {MediaId}\nTitle: {Title}\nGenres: {string.Join(", ", Genres)}\n";
        }
    }

    public class Movie : Media
    {
        public string Director { get; set; }
        public TimeSpan RunningTime { get; set; }
    }
}