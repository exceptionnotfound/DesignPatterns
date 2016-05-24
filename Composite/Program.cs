using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaFountain fountain = new SodaFountain();
            fountain.Colas.AvailableFlavors.Add(new Cola(220));
            fountain.Colas.AvailableFlavors.Add(new CherryCola(230));
            fountain.LemonLime.Calories = 180;
            fountain.RootBeers.AvailableFlavors.Add(new RootBeer(225));
            fountain.RootBeers.AvailableFlavors.Add(new VanillaRootBeer(225));
            fountain.DisplayCalories();
            // Wait for user
            Console.ReadKey();
        }
    }
}
