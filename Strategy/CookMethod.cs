using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// The Strategy abstract class, which defines an interface common to all supported strategy algorithms.
    /// </summary>
    abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class Grilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class OvenBaking : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by oven baking it.");
        }
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class DeepFrying : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it");
        }
    }

    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    class CookingMethod
    {
        private string Food;
        private CookStrategy _cookStrategy;

        public void SetCookStrategy(CookStrategy cookStrategy)
        {
            this._cookStrategy = cookStrategy;
        }

        public void SetFood(string name)
        {
            Food = name;
        }

        public void Cook()
        {
            _cookStrategy.Cook(Food);
            Console.WriteLine();
        }
    }
}
