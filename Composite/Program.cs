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
            var colas = new Cola(210);
            colas.Flavors.Add(new VanillaCola(215));
            colas.Flavors.Add(new CherryCola(210));

            var lemonLime = new LemonLime(185);

            var rootBeers = new RootBeer(195);
            rootBeers.Flavors.Add(new VanillaRootBeer(200));
            rootBeers.Flavors.Add(new StrawberryRootBeer(200));

            Soda allDrinks = new Soda(180);
            allDrinks.Flavors.Add(colas);
            allDrinks.Flavors.Add(lemonLime);
            allDrinks.Flavors.Add(rootBeers);

            allDrinks.DisplayCalories();

            Console.ReadKey();
        }
    }
}
