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
        private int _numAvailable { get; set; }

        public int NumAvailable
        {
            get
            {
                return _numAvailable;
            }
            set
            {
                _numAvailable = value;
            }
        }

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

        public FreshSalad(string greens, string cheese, string dressing, int numAvailable)
        {
            _greens = greens;
            _cheese = cheese;
            _dressing = dressing;
            NumAvailable = numAvailable;
        }

        public override void Display()
        {
            Console.WriteLine("\nFresh Salad:");
            Console.WriteLine(" Greens: {0}" + _greens);
            Console.WriteLine(" Cheese: {0}" + _cheese);
            Console.WriteLine(" Dressing: {0}" + _dressing);
        }
    }

    /// <summary>
    /// A Concrete component class
    /// </summary>
    class Pasta : RestaurantDish
    {
        private string _pastaType;
        private string _sauce;

        public Pasta(string pastaType, string sauce, int numAvailable)
        {
            _pastaType = pastaType;
            _sauce = sauce;
            NumAvailable = numAvailable;
        }

        public override void Display()
        {
            Console.WriteLine("\nClassic Pasta:");
            Console.WriteLine(" Pasta: {0}" + _pastaType);
            Console.WriteLine(" Sauce: {0}" + _sauce);
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
        protected List<string> customers = new List<string>();
        public Available(RestaurantDish dish) : base(dish)
        {

        }

        public void OrderItem(string name)
        {
            if (_dish.NumAvailable > 0)
            {
                customers.Add(name);
                _dish.NumAvailable--;
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
