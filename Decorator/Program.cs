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
            FreshSalad caesarSalad = new FreshSalad("Crisp romaine lettuce", "Freshly-grated Parmesan cheese", "House-made Caesar dressing", 3);
            caesarSalad.Display();

            Pasta fettuccineAlfredo = new Pasta("Fresh-made daily pasta", "Creamly garlic alfredo sauce", 4);
            fettuccineAlfredo.Display();

            Console.WriteLine("\nMaking these dishes orderable.");

            Available caesarAvailable = new Available(caesarSalad);
            Available alfredoAvailable = new Available(fettuccineAlfredo);

            caesarAvailable.OrderItem("John");
            caesarAvailable.OrderItem("Sally");
            caesarAvailable.OrderItem("Manush");

            alfredoAvailable.OrderItem("Sally");
            alfredoAvailable.OrderItem("Francis");
            alfredoAvailable.OrderItem("Venkat");
            alfredoAvailable.OrderItem("Diana");
            alfredoAvailable.OrderItem("Dennis");

            caesarAvailable.Display();
            alfredoAvailable.Display();

            Console.ReadKey();
        }
    }
}
