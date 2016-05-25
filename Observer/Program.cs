using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create price watch for Carrots and attach restaurants that buy carrots.
            Carrots carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Mackay's"));
            carrots.Attach(new Restaurant("Johnny's Sports Bar"));
            carrots.Attach(new Restaurant("Salad Kingdom"));

            // Fluctuating carrot prices will notify restaurants automatically.
            carrots.PricePerPound = 0.79;
            carrots.PricePerPound = 0.78;
            carrots.PricePerPound = 0.82;
            carrots.PricePerPound = 0.86;

            Console.ReadKey();
        }
    }
}
