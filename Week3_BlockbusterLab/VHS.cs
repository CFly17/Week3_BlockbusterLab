using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS()
        {
            this.CurrentTime = CurrentTime;
        }

        //Method to increment playtime
        public void Play()
        {
            CurrentTime++;
        }

        //Method to set CurrentTime to 0
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
