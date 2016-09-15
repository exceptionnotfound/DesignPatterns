using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// All items sold in the restaurant must inherit from this.
    /// </summary>
    class FoodItem { public int DishID; }

    /// <summary>
    /// Each section of the kitchen must implement this interface.
    /// </summary>
    interface KitchenSection
    {
        FoodItem PrepDish(int DishID);
    }

    /// <summary>
    /// Orders placed by Patrons.
    /// </summary>
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
    /// A division of the kitchen.
    /// </summary>
    class ColdPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            Console.WriteLine("Cold Prep is preparing Appetizer #" + dishID);
            //Go prep the appetizer
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class HotPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            Console.WriteLine("Hot Prep is preparing Entree #" + dishID);
            //Go prep the entree
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class Bar : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            Console.WriteLine("The Bar is preparing Drink #" + dishID);
            //Go mix the drink
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// The actual "Facade" class, which hides the complexity of the KitchenSection classes.
    /// After all, there's no reason a patron should order each part of their meal individually.
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
                                + ", and drink #" + drinkID.ToString() + ".", patron.Name);

            Order order = new Order();

            order.Appetizer = _coldPrep.PrepDish(coldAppID);
            order.Entree = _hotPrep.PrepDish(hotEntreeID);
            order.Drink = _bar.PrepDish(drinkID);

            return order;
        }
    }
}
