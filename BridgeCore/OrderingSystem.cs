using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Implementor which defines an interface for placing an order
    /// </summary>
    public interface IOrderingSystem
    {
        void Place(string order);
    }

    /// <summary>
    /// Abstraction which represents the sent order and maintains a reference to the restaurant where the order is going.
    /// </summary>
    public abstract class SendOrder
    {
        //Reference to the Implementor
        public IOrderingSystem _restaurant;

        public abstract void Send();
    }

    /// <summary>
    /// Refined abstraction for a dairy-free order
    /// </summary>
    public class SendDairyFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Dairy-Free Order");
        }
    }

    /// <summary>
    /// Refined abstraction for a gluten free order
    /// </summary>
    public class SendGlutenFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Gluten-Free Order");
        }
    }

    /// <summary>
    /// Concrete implementor for an ordering system at a diner.
    /// </summary>
    public class DinerOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for " + order + " at the Diner.");
        }
    }

    /// <summary>
    /// Concrete implementor for an ordering system at a fancy restaurant.
    /// </summary>
    public class FancyRestaurantOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for " + order + " at the Fancy Restaurant.");
        }
    }
}
