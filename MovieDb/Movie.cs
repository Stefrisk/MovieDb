using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDb
{
    internal class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public List<Actor> MovieCast { get; set; }
        public Movie(string title, int runTime, List<Actor> movieCast)
        {
            Title = title;
            RunTime = runTime;
            MovieCast = movieCast;
        }
       

    }
    internal class Comedy : Movie
    {
        public int NumberOfFunnyScenes { get; set; }
        public Comedy(string title, int runTime, List<Actor> movieCast, int numberOfFunnyScenes) : base(title, runTime, movieCast)
        {
            NumberOfFunnyScenes = numberOfFunnyScenes;
        }
    }
    internal class Action : Movie
    {
        public int NumOfShotsFired { get; set; }
        public Action(string title, int runTime, List<Actor> movieCast, int numberOfShotsFired) : base(title, runTime, movieCast)
        {
            NumOfShotsFired = numberOfShotsFired;
        }
    }
    internal class SciFi : Movie
    {
        public int NumOfSpaceShips { get; set; }
        public SciFi(string title, int runTime, List<Actor> movieCast, int numOfSpaceShips) : base(title, runTime, movieCast)
        {
            NumOfSpaceShips = numOfSpaceShips;
        }

    }

}
