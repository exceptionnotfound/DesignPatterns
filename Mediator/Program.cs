using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            KitchenMediator m = new KitchenMediator();

            LeftSideKitchen c1 = new LeftSideKitchen(m);
            RightSideKitchen c2 = new RightSideKitchen(m);

            m.LeftKitchen = c1;
            m.RightKitchen = c2;

            c1.Send("Can you send some popcorn?");
            c2.Send("Sure thing, Kenny's on his way.");

            c2.Send("Do you have any extra hot dogs?  We've had a rush on them over here.");
            c1.Send("Just a couple, we'll send Kenny back with them.");

            Console.ReadKey();
        }
    }
}
