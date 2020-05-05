using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// Component abstract class
    /// </summary>
    public abstract class SoftDrink
    {
        public int Calories { get; set; }

        public List<SoftDrink> Flavors { get; set; }

        public SoftDrink(int calories)
        {
            Calories = calories;
            Flavors = new List<SoftDrink>();
        }

        /// <summary>
        /// "Flatten" method, returns all available flavors
        /// </summary>
        public void DisplayCalories()
        {
            Console.WriteLine(this.GetType().Name + ": " + this.Calories.ToString() + " calories.");
            foreach (var drink in this.Flavors)
            {
                drink.DisplayCalories();
            }
        }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class VanillaCola : SoftDrink
    {
        public VanillaCola(int calories) : base(calories) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class CherryCola : SoftDrink
    {
        public CherryCola(int calories) : base(calories) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class StrawberryRootBeer : SoftDrink
    {
        public StrawberryRootBeer(int calories) : base(calories) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class VanillaRootBeer : SoftDrink
    {
        public VanillaRootBeer(int calories) : base(calories) { }
    }

    /// <summary>
    /// Composite class
    /// </summary>
    public class Cola : SoftDrink
    {
        public Cola(int calories) : base(calories) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class LemonLime : SoftDrink
    {
        public LemonLime(int calories) : base(calories) { }
    }

    /// <summary>
    /// Composite class
    /// </summary>
    public class RootBeer : SoftDrink
    {
        public RootBeer(int calories) : base(calories) { }
    }

    /// <summary>
    /// Composite class, root node
    /// </summary>
    public class SodaWater : SoftDrink
    {
        public SodaWater(int calories) : base(calories) { }
    }
}
