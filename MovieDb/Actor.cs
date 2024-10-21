using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDb
{
    internal class Actor
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Actor(string name, int age)
        {
            Age = age;
            Name = name;
        }
        public static List<Actor> MakeActorList()
        {
            List<Actor> actorList = new List<Actor>();
            Console.WriteLine("How many actors are in the movie?: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= amount; i++)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Actor actor = new Actor(name, age);
                actorList.Add(actor);

            }
            return actorList;

        }

    }
}
