using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class FoodItem { public int DishID; }

    interface KitchenSection
    {
        FoodItem PrepDish(int DishID);
    }

    class Order
    {
        public FoodItem Appetizer { get; set; }
        public FoodItem Entree { get; set; }
        public FoodItem Drink { get; set; }
    }

    /// <summary>
    /// Patron of the restaurant
    /// </summary>
    class Patron
    {
        private string _name;

        public Patron(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }


    /// <summary>
    /// A subsystem class
    /// </summary>
    class ColdPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the appetizer
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// A subsystem class
    /// </summary>
    class HotPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the entree
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// A subsystem class
    /// </summary>
    class Bar : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go mix the drink
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// The Facade class
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

            order.Appetizer = _coldPrep.PrepDish(coldAppID);
            order.Entree = _hotPrep.PrepDish(hotEntreeID);
            order.Drink = _bar.PrepDish(drinkID);

            return order;
        }
    }
}
