using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        /// <summary>
        /// The Command pattern encapsulates commands as objects, allowing them to be executed by a Receiver class and kicked off
        /// by an Invoker object.  This enables more complex architectures such as CQRS (Command/Query Responsibility Segregation).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FastFoodOrder order = new FastFoodOrder();

            //Add some items
            order.SubmitCommand(1 /*Add*/, new MenuItem("French Fries", 2, 1.99));
            order.SubmitCommand(1 /*Add*/, new MenuItem("Hamburger", 2, 2.59));
            order.SubmitCommand(1 /*Add*/, new MenuItem("Drink", 2, 1.19));

            order.ShowCurrentItems();

            //Remove the french fries
            order.SubmitCommand(3 /*Remove*/, new MenuItem("French Fries", 2, 1.19));

            order.ShowCurrentItems();

            //Now we want 4 hamburgers rather than 2
            order.SubmitCommand(2 /*Modify*/, new MenuItem("Hamburger", 4, 2.79));

            order.ShowCurrentItems();
            Console.ReadKey();
        }
    }
}
