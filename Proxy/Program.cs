using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            NewServerProxy proxy = new NewServerProxy();

            //Manage orders from a table
            Console.WriteLine("What would you like to order? ");
            string order = Console.ReadLine();
            proxy.TakeOrder(order);
            Console.WriteLine("Sure thing!  Here's your " + proxy.DeliverOrder() + ".");
            Console.WriteLine("How would you like to pay?");
            string payment = Console.ReadLine();
            proxy.ProcessPayment(payment);

            Console.ReadKey();
        }
    }
}
