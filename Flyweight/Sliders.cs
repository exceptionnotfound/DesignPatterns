using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    class SliderFactory
    {
        private Dictionary<char, Slider> _characters =
          new Dictionary<char, Slider>();

        public Slider GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Slider character = null;
            if (_characters.ContainsKey(key))
            {
                character = _characters[key];
            }
            else
            {
                switch (key)
                {
                    case 'A': character = new BaconMaster(); break;
                    case 'B': character = new VeggieSlider(); break;
                    //...
                    case 'Z': character = new BBQKing(); break;
                }
                _characters.Add(key, character);
            }
            return character;
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
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class BaconMaster : Slider
    {
        // Constructor
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
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class VeggieSlider : Slider
    {
        // Constructor
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

    // ... C, D, E, etc.

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class BBQKing : Slider
    {
        // Constructor
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
