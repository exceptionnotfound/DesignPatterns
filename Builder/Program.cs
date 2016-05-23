using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichBuilder builder;

            // Create shop with vehicle builders
            AssemblyLine shop = new AssemblyLine();

            // Construct and display vehicles
            builder = new HamAndCheese();
            shop.Assemble(builder);
            builder.Vehicle.Show();

            builder = new BLT();
            shop.Assemble(builder);
            builder.Vehicle.Show();

            builder = new TurkeyClub();
            shop.Assemble(builder);
            builder.Vehicle.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
