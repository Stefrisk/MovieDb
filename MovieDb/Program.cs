using System.Diagnostics.CodeAnalysis;

namespace MovieDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            int choice = 0;
            List<Movie> MovieList = new List<Movie>();
            while (menu)
            {
                Console.WriteLine("Welcome to the film Library\n1) Add new movie");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) 
                {
                    case 1: 
                        int choice2 = 0;
                        Console.Clear();
                        Console.WriteLine("What kind of movie would you like to add?\n1)Comedy\n2)Action\n3)SciFi");
                        switch (choice2)
                        {
                            case 1:
                                Console.WriteLine("Title: ");
                                string title = Console.ReadLine();
                                Console.WriteLine("Length in mins: ");
                                int runTime = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Number of funny scenes:  ");
                                int funnyScenes = Convert.ToInt32(Console.ReadLine());
                                List<Actor> actors = new List<Actor>();
                                actors = Actor.MakeActorList();
                                

                                Comedy comedy = new Comedy(title, runTime,actors,funnyScenes);
                                MovieList.Add(comedy);
                                break;

                                        

                        }

                }

            }

        }
    }
}
