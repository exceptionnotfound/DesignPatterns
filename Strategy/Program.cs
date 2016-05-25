using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CookingMethod cookMethod = new CookingMethod();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            cookMethod.SetFood(food);

            Console.WriteLine("What cooking method would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());
            

            switch(input)
            {
                case 1:
                    cookMethod.SetSortStrategy(new Grilling());
                    cookMethod.Sort();
                    break;

                case 2:
                    cookMethod.SetSortStrategy(new OvenBaking());
                    cookMethod.Sort();
                    break;

                case 3:
                    cookMethod.SetSortStrategy(new DeepFrying());
                    cookMethod.Sort();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
