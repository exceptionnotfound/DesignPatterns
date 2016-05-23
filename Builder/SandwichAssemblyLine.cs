using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// The Director
    /// </summary>
    class AssemblyLine
    {
        // Builder uses a complex series of steps
        // 
        public void Assemble(SandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.AddBread();
            sandwichBuilder.AddMeats();
            sandwichBuilder.AddCheese();
            sandwichBuilder.AddVeggies();
            sandwichBuilder.AddCondiments();
        }
    }

    /// <summary>
    /// The Builder abstract class
    /// </summary>
    abstract class SandwichBuilder
    {
        protected Sandwich vehicle;

        // Gets vehicle instance
        public Sandwich Vehicle
        {
            get { return vehicle; }
        }

        // Abstract build methods
        public abstract void AddBread();
        public abstract void AddMeats();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }

    /// <summary>
    /// A Concrete Builder class
    /// </summary>
    class TurkeyClub : SandwichBuilder
    {
        public TurkeyClub()
        {
            vehicle = new Sandwich("Turkey Club");
        }

        public override void AddBread()
        {
            vehicle["bread"] = "12-Grain";
        }

        public override void AddMeats()
        {
            vehicle["meat"] = "Turkey";
        }

        public override void AddCheese()
        {
            vehicle["cheese"] = "Swiss";
        }

        public override void AddVeggies()
        {
            vehicle["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            vehicle["condiments"] = "Mayo";
        }
    }


    /// <summary>
    /// A Concrete Builder class
    /// </summary>
    class BLT : SandwichBuilder
    {
        public BLT()
        {
            vehicle = new Sandwich("BLT");
        }

        public override void AddBread()
        {
            vehicle["bread"] = "Wheat";
        }

        public override void AddMeats()
        {
            vehicle["meat"] = "Bacon";
        }

        public override void AddCheese()
        {
            vehicle["cheese"] = "None";
        }

        public override void AddVeggies()
        {
            vehicle["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            vehicle["condiments"] = "Mayo, Mustard";
        }
    }

    /// <summary>
    /// A Concrete Builder class
    /// </summary>
    class HamAndCheese : SandwichBuilder
    {
        public HamAndCheese()
        {
            vehicle = new Sandwich("Ham and Cheese");
        }

        public override void AddBread()
        {
            vehicle["bread"] = "White";
        }

        public override void AddMeats()
        {
            vehicle["meat"] = "Ham";
        }

        public override void AddCheese()
        {
            vehicle["cheese"] = "American";
        }

        public override void AddVeggies()
        {
            vehicle["veggies"] = "None";
        }

        public override void AddCondiments()
        {
            vehicle["condiments"] = "Mayo";
        }
    }

    /// <summary>
    /// The Product class
    /// </summary>
    class Sandwich
    {
        private string _sandwichType;
        private Dictionary<string, string> _ingredients = new Dictionary<string, string>();

        // Constructor
        public Sandwich(string sandwichType)
        {
            this._sandwichType = sandwichType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _ingredients[key]; }
            set { _ingredients[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Sandwich: {0}", _sandwichType);
            Console.WriteLine(" Bread: {0}", _ingredients["bread"]);
            Console.WriteLine(" Meat: {0}", _ingredients["meat"]);
            Console.WriteLine(" Cheese: {0}", _ingredients["cheese"]);
            Console.WriteLine(" Veggies: {0}", _ingredients["veggies"]);
            Console.WriteLine(" Condiments: {0}", _ingredients["condiments"]);
        }
    }
}
