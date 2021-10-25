using System;
using System.Collections.Generic;

namespace Week3_BlockbusterLab
{
    class Movie
    {
        //Scenes
        public string[] scenesArray = new string[] { "Intro", "Second part", "Third part", "Climax", "Denouement", "Finale"};

        public string Title { get; set; }
        public string Genre { get; set; }
        public int RunTime { get; set; }

        public Movie(string Title, string Genre, int RunTime)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.RunTime = RunTime;
        }

        public string PrintInfo(string Title, string Genre, int RunTime)
        {

            for (int i = 0; i < MoviesList.Count; i++)
            {
                Console.WriteLine(MoviesList[i]);
            }

        }

        //PRINT ALL SCENES + THEIR INDEX
        public string PrintScenes(string MovieList)
        {
            foreach (string Scenes in MovieList)
            {
                System.Console.WriteLine("Here are the scenes for the movie you've selected:");
            }
        }
        public virtual void Play()
        {

        }
    }

}
