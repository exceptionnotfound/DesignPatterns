using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// The Strategy abstract class
    /// </summary>
    abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }

    /// <summary>
    /// A ConcreteStrategy class
    /// </summary>
    class Grilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }

    /// <summary>
    /// A ConcreteStrategy class
    /// </summary>
    class OvenBaking : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by oven baking it.");
        }
    }

    /// <summary>
    /// A ConcreteStrategy class
    /// </summary>
    class DeepFrying : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it");
        }
    }

    /// <summary>
    /// The Context class
    /// </summary>
    class CookingMethod
    {
        private string Food;
        private CookStrategy _sortstrategy;

        public void SetSortStrategy(CookStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void SetFood(string name)
        {
            Food = name;
        }

        public void Sort()
        {
            _sortstrategy.Cook(Food);
            Console.WriteLine();
        }
    }
}
