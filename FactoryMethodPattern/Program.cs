using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Recipe> sandwiches = new List<Recipe>();
            sandwiches.Add(new TurkeySandwich());
            sandwiches.Add(new Dagwood());

            foreach(var sandwich in sandwiches)
            {
                Console.WriteLine("\nSandwich: " + sandwich.GetType().Name + " ");
                foreach(var weapon in sandwich.Ingredients)
                {
                    Console.WriteLine("Ingredient: " + weapon.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
