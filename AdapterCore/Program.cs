using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Non-adapted
            Meat unknown = new Meat("Beef");
            unknown.LoadData();

            //Adapted
            MeatDetails beef = new MeatDetails("Beef");
            beef.LoadData();

            MeatDetails turkey = new MeatDetails("Turkey");
            turkey.LoadData();

            MeatDetails chicken = new MeatDetails("Chicken");
            chicken.LoadData();

            Console.ReadKey();
        }
    }
}
