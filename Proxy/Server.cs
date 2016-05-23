using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// The Subject interface which both the real subject and proxy will need to implement
    /// </summary>
    public interface IServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }

    /// <summary>
    /// The real subject class which the Proxy can stand in for
    /// </summary>
    class Server : IServer
    {
        private string Order;
        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for " + order + ".");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for order (" + payment + ") processed.");
        }
    }

    /// <summary>
    /// The Proxy class, which can substitute for the Real Subject.
    /// </summary>
    class ServerProxy : IServer
    {
        private Server _server = new Server();

        public void TakeOrder(string order)
        {
            _server.TakeOrder(order);
        }

        public string DeliverOrder()
        {
            return _server.DeliverOrder();
        }

        public void ProcessPayment(string payment)
        {
            _server.ProcessPayment(payment);
        }
    }
}
