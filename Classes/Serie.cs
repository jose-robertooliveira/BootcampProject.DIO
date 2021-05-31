using System;

namespace InternationalSeries.D
{
    public class Serie : BaseObject
    {
        private Genres Genres { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int ReleaseYear { get; set; }

        private bool Erased { get; set; }

        public Serie(int id, Genres genres, string title, string description, int release_year)
        {
            this.Id = id;
            this.Genres = genres;
            this.Title = title;
            this.Description = description;
            this.ReleaseYear = release_year;
            this.Erased = false;

        }

        public Serie()
        {
        }

        public override string ToString()
        {
            string s = "";
            s += "Genres: " + this.Genres + Environment.NewLine;
            s += "Title: " + this.Title + Environment.NewLine;
            s += "Description: " + this.Description + Environment.NewLine;
            s += "Release Year: " + this.ReleaseYear + Environment.NewLine;
           
            return s;
        }

        public string showTitle() 
        {
            return this.Title;
        }

        public int showId()
        {
            return this.Id;
        }
        public void Erase() 
        {
            this.Erased = true;
        }
    }
}
