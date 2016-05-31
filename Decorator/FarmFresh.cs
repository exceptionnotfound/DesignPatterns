using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// The abstract Component class
    /// </summary>
    abstract class RestaurantDish
    {
        public abstract void Display();
    }

    /// <summary>
    /// A Concrete component class
    /// </summary>
    class FreshSalad : RestaurantDish
    {
        private string _greens;
        private string _cheese; //I am going to use this pun everywhere I can
        private string _dressing;

        public FreshSalad(string greens, string cheese, string dressing)
        {
            _greens = greens;
            _cheese = cheese;
            _dressing = dressing;
        }

        public override void Display()
        {
            Console.WriteLine("\nFresh Salad:");
            Console.WriteLine(" Greens: {0}", _greens);
            Console.WriteLine(" Cheese: {0}", _cheese);
            Console.WriteLine(" Dressing: {0}", _dressing);
        }
    }

    /// <summary>
    /// A Concrete component class
    /// </summary>
    class Pasta : RestaurantDish
    {
        private string _pastaType;
        private string _sauce;

        public Pasta(string pastaType, string sauce)
        {
            _pastaType = pastaType;
            _sauce = sauce;
        }

        public override void Display()
        {
            Console.WriteLine("\nClassic Pasta:");
            Console.WriteLine(" Pasta: {0}", _pastaType);
            Console.WriteLine(" Sauce: {0}", _sauce);
        }
    }

    /// <summary>
    /// The abstract Decorator class.  
    /// </summary>
    abstract class Decorator : RestaurantDish
    {
        protected RestaurantDish _dish;

        public Decorator(RestaurantDish dish)
        {
            _dish = dish;
        }

        public override void Display()
        {
            _dish.Display();
        }
    }

    /// <summary>
    /// A concrete Decorator. This class will impart "responsibilities" onto the dishes (e.g. whether or not those dishes have enough ingredients left to order them)
    /// </summary>
    class Available : Decorator
    {
        public int NumAvailable { get; set; } //How many can we make?
            protected List<string> customers = new List<string>();
        public Available(RestaurantDish dish, int numAvailable) : base(dish)
        {
                NumAvailable = numAvailable;
        }

        public void OrderItem(string name)
        {
            if (NumAvailable > 0)
            {
                customers.Add(name);
                NumAvailable--;
            }
            else
            {
                Console.WriteLine("\nNot enough ingredients for " + name + "'s order!");
            }
        }

        public override void Display()
        {
            base.Display();

            foreach(var customer in customers)
            {
                Console.WriteLine("Ordered by " + customer);
            }
        }
    }
}
