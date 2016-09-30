using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SendOrder _sendOrder = new SendDairyFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();

            _sendOrder = new SendGlutenFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();

            Console.ReadKey();
        }
    }
}
