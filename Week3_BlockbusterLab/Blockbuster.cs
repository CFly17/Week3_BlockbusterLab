using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_BlockbusterLab
{
    class Blockbuster : Movie
    {
        public List<Movie> MoviesList { get; set; } = new List<Movie>();

        public List Movie(string Title, string Genre, int RunTime)
        {
            MoviesList.Add(new Movie("Terrifier", "Horror", 86));
            MoviesList.Add(new Movie("Hellraiser", "Horror", 94));
            MoviesList.Add(new Movie("Gone with the Wind", "Drama", 238));
            MoviesList.Add(new Movie("Pineapple Express", "Comedy", 117));
            MoviesList.Add(new Movie("Pirates of the Caribbean", "Action", 143));
            MoviesList.Add(new Movie("The Notebook", "Romance", 124));
        }
    }
}
