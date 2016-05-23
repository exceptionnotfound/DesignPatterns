using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichMenu sandwichMenu = new SandwichMenu();

            // Initialize with standard colors
            sandwichMenu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
            sandwichMenu["PB&J"] = new Sandwich("White", "", "", "Peanut Butter, Jelly");
            sandwichMenu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");

            // User adds personalized colors
            sandwichMenu["LoadedBLT"] = new Sandwich("Wheat", "Turkey, Bacon", "American", "Lettuce, Tomato, Onion, Olives");
            sandwichMenu["ThreeMeatCombo"] = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Lettuce, Onion");
            sandwichMenu["Vegetarian"] = new Sandwich("Wheat", "", "", "Lettuce, Onion, Tomato, Olives, Spinach");

            // User clones selected colors
            Sandwich sandwich1 = sandwichMenu["BLT"].Clone() as Sandwich;
            Sandwich sandwich2 = sandwichMenu["ThreeMeatCombo"].Clone() as Sandwich;
            Sandwich sandwich3 = sandwichMenu["Vegetarian"].Clone() as Sandwich;

            // Wait for user
            Console.ReadKey();
        }
    }
}
