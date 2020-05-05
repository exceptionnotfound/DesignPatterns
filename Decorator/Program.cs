using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        /// <summary>
        /// We run a farm-fresh restaurant.
        /// That means that we can only make dishes which we have the ingredients for.
        /// Sometimes we run out of ingredients, so we can't make those dishes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Step 1: Define some dishes, and how many of each we can make
            FreshSalad caesarSalad = new FreshSalad("Crisp romaine lettuce", "Freshly-grated Parmesan cheese", "House-made Caesar dressing");
            caesarSalad.Display();

            Pasta fettuccineAlfredo = new Pasta("Fresh-made daily pasta", "Creamly garlic alfredo sauce");
            fettuccineAlfredo.Display();

            Console.WriteLine("\nMaking these dishes available.");

            //Step 2: Decorate the dishes; now if we attempt to order them once we're out of ingredients, we can notify the customer
            Available caesarAvailable = new Available(caesarSalad, 3);
            Available alfredoAvailable = new Available(fettuccineAlfredo, 4);

            //Step 3: Order a bunch of dishes
            caesarAvailable.OrderItem("John");
            caesarAvailable.OrderItem("Sally");
            caesarAvailable.OrderItem("Manush");

            alfredoAvailable.OrderItem("Sally");
            alfredoAvailable.OrderItem("Francis");
            alfredoAvailable.OrderItem("Venkat");
            alfredoAvailable.OrderItem("Diana");
            alfredoAvailable.OrderItem("Dennis"); //There won't be enough for this order.

            caesarAvailable.Display();
            alfredoAvailable.Display();

            Console.ReadKey();
        }
    }
}
