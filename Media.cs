using System;
using System.Collections.Generic;

namespace MediaLibrary
{
    public abstract class Media
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
        public virtual string Display()
        {
            return $"Id: {MediaId}\nTitle: {Title}\nGenres: {string.Join(", ", Genres)}\n";
        }
    }

    public class Movie : Media
    {
        public string Director { get; set; }
        public TimeSpan RunningTime { get; set; }
        
        public override string Display()
        {
            return $"Id: {MediaId}\nTitle: {Title}\nDirector: {Director}\nRun time: {RunningTime}\nGenres: {string.Join(", ", Genres)}\n";
        }
    }
    
    public class Album : Media
    {
        public string Artist { get; set; }
        public string RecordLabel { get; set; }

        public override string Display()
        {
            return $"Id: {MediaId}\nTitle: {Title}\nArtist: {Artist}\nLabel: {RecordLabel}\nGenres: {string.Join(", ", Genres)}\n";
        }
    }
    
    // Book class is derived from Media class
    public class Book : Media
    {
        public string Author { get; set; }
        public UInt16 PageCount { get; set; }
        public string Publisher { get; set; }

        public override string Display()
        {
            return $"Id: {MediaId}\nTitle: {Title}\nAuthor: {Author}\nPages: {PageCount}\nPublisher: {Publisher}\nGenres: {string.Join(", ", Genres)}\n";
        }
    }
}