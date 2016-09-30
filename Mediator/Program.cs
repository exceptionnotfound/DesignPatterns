using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        /// <summary>
        /// The Mediator pattern allows us to create an object which defines how other objects interact or 
        /// communicate with each other.  This pattern promotes loose coupling by keeping the interacting
        /// objects from referring to each other explicitly.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ConcessionsMediator mediator = new ConcessionsMediator();

            NorthConcessionStand leftKitchen = new NorthConcessionStand(mediator);
            SouthConcessionStand rightKitchen = new SouthConcessionStand(mediator);

            mediator.NorthConcessions = leftKitchen;
            mediator.SouthConcessions = rightKitchen;

            leftKitchen.Send("Can you send some popcorn?");
            rightKitchen.Send("Sure thing, Kenny's on his way.");

            rightKitchen.Send("Do you have any extra hot dogs?  We've had a rush on them over here.");
            leftKitchen.Send("Just a couple, we'll send Kenny back with them.");

            Console.ReadKey();
        }
    }
}
