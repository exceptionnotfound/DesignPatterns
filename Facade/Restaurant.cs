using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SellableItem { public int DishID; }
    class HotEntree : SellableItem { }
    class ColdApp : SellableItem { }
    class Drink : SellableItem { }

    class Order
    {
        public ColdApp Appetizer { get; set; }
        public HotEntree Entree { get; set; }
        public Drink Drink { get; set; }
    }

    /// <summary>
    /// Patron of the restaurant
    /// </summary>
    class Patron
    {
        private string _name;

        // Constructor
        public Patron(string name)
        {
            this._name = name;
        }

        // Gets the name
        public string Name
        {
            get { return _name; }
        }
    }


    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    class ColdPrep
    {
        public ColdApp GetColdApp(int dishID)
        {
            //Go prep the appetizer
            return new ColdApp()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    class HotPrep
    {
        public HotEntree GetHotEntree(int dishID)
        {
            //Go prep the entree
            return new HotEntree()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
    class Bar
    {
        public Drink GetDrink(int dishID)
        {
            //Go mix the drink
            return new Drink()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// The 'Facade' class
    /// </summary>
    class Server
    {
        private ColdPrep _coldPrep = new ColdPrep();
        private Bar _bar = new Bar();
        private HotPrep _hotPrep = new HotPrep();

        public Order PlaceOrder(Patron patron, int coldAppID, int hotEntreeID, int drinkID)
        {
            Console.WriteLine("{0} places order for cold app #" + coldAppID.ToString()
                                + ", hot entree #" + hotEntreeID.ToString()
                                + ", and drink #" + drinkID.ToString() + ".");

            Order order = new Order();

            order.Appetizer = _coldPrep.GetColdApp(coldAppID);
            order.Entree = _hotPrep.GetHotEntree(hotEntreeID);
            order.Drink = _bar.GetDrink(drinkID);

            return order;
        }
    }
}
