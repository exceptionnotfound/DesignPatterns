using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Non-adapted
            Meat unknown = new Meat("Beef");
            unknown.Display();

            //Adapted
            MeatDetails beef = new MeatDetails("Beef");
            beef.Display();

            MeatDetails turkey = new MeatDetails("Turkey");
            turkey.Display();

            MeatDetails chicken = new MeatDetails("Chicken");
            chicken.Display();

            Console.ReadKey();
        }
    }
}
