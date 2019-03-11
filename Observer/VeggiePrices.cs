using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// The Subject abstract class
    /// </summary>
    abstract class Veggies
    {
        private double _pricePerPound;
        private List<IRestaurant> _restaurants = new List<IRestaurant>();

        public Veggies(double pricePerPound)
        {
            _pricePerPound = pricePerPound;
        }

        public void Attach(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (IRestaurant restaurant in _restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine("");
        }

        public double PricePerPound
        {
            get { return _pricePerPound; }
            set
            {
                if (_pricePerPound != value)
                {
                    _pricePerPound = value;
                    Notify();
                }
            }
        }
    }

    /// <summary>
    /// The ConcreteSubject class
    /// </summary>
    class Carrots : Veggies
    {
        public Carrots(double price) : base(price)
        {
        }
    }

    /// <summary>
    /// The Observer interface
    /// </summary>
    interface IRestaurant
    {
        void Update(Veggies veggies);
    }

    /// <summary>
    /// The ConcreteObserver class
    /// </summary>
    class Restaurant : IRestaurant
    {
        private string _name;
        private double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Veggies veggie)
        {
            Console.WriteLine("Notified {0} of {1}'s " + " price change to {2:C} per pound.", _name, veggie.GetType().Name, veggie.PricePerPound);
            if(veggie.PricePerPound < _purchaseThreshold)
            {
                Console.WriteLine(_name + " wants to buy some " + veggie.GetType().Name + "!");
            }
        }
    }
}
