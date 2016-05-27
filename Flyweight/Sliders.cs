using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    /// <summary>
    /// The Flyweight Factory class
    /// </summary>
    class SliderFactory
    {
        private Dictionary<char, Slider> _sliders =
            new Dictionary<char, Slider>();

        public Slider GetSlider(char key)
        {
            Slider slider = null;
            if (_sliders.ContainsKey(key)) //If we've already created an instance of the requested type of slider, just use that.
            {
                slider = _sliders[key];
            }
            else //Otherwise, create a brand new slider instance.
            {
                switch (key)
                {
                    case 'B': slider = new BaconMaster(); break;
                    case 'V': slider = new VeggieSlider(); break;
                    case 'Q': slider = new BBQKing(); break;
                }
                _sliders.Add(key, slider);
            }
            return slider;
        }
    }

    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    abstract class Slider
    {
        protected string Name;
        protected string Cheese;
        protected string Toppings;
        protected decimal Price;

        public abstract void Display(int orderTotal);
    }

    /// <summary>
    /// A  Concrete Flyweight class
    /// </summary>
    class BaconMaster : Slider
    {
        public BaconMaster()
        {
            Name = "Bacon Master";
            Cheese = "American";
            Toppings = "lots of bacon";
            Price = 2.39m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " + Toppings + "! $" + Price.ToString());
        }
    }

    /// <summary>
    /// A Concrete Flyweight class
    /// </summary>
    class VeggieSlider : Slider
    {
        public VeggieSlider()
        {
            Name = "Veggie Slider";
            Cheese = "Swiss";
            Toppings = "lettuce, onion, tomato, and pickles";
            Price = 1.99m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " + Toppings + "! $" + Price.ToString());
        }

    }

    /// <summary>
    /// A Concrete Flyweight class
    /// </summary>
    class BBQKing : Slider
    {
        public BBQKing()
        {
            Name = "BBQ King";
            Cheese = "American";
            Toppings = "Onion rings, lettuce, and BBQ sauce";
            Price = 2.49m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " + Toppings + "! $" + Price.ToString());
        }
    }
}
