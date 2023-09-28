using System;
namespace Entities
{
    internal class Song
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Composer { get; set; }
        public int Year { get; set; }

        public Song()
        {
            Id = Guid.NewGuid();
        }
        public Song(string title, string composer, int year) : this()
        {
            Title = title;
            Composer = composer;
            Year = year;
        }

    }
}

