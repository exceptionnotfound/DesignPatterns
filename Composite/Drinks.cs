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

        public SoftDrink(int calories)
        {
            Calories = calories;
        }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class OriginalCola : SoftDrink
    {
        public OriginalCola(int calories) : base(calories) { }
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
    public class OriginalRootBeer : SoftDrink
    {
        public OriginalRootBeer(int calories) : base(calories) { }
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
    public class Colas
    {
        public List<SoftDrink> AvailableFlavors { get; set; }

        public Colas()
        {
            AvailableFlavors = new List<SoftDrink>();
        }
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
    public class RootBeers
    {
        public List<SoftDrink> AvailableFlavors { get; set; }

        public RootBeers()
        {
            AvailableFlavors = new List<SoftDrink>();
        }
    }

    /// <summary>
    /// The Client class
    /// </summary>
    public class SodaDispenser
    {
        public Colas Colas { get; set; }
        public LemonLime LemonLime { get; set; }
        public RootBeers RootBeers { get; set; }

        public SodaDispenser()
        {
            Colas = new Colas();
            LemonLime = new LemonLime(190);
            RootBeers = new RootBeers();
        }

        /// <summary>
        /// "Flatten" method, returns all available flavors
        /// </summary>
        public void DisplayCalories()
        {
            var sodas = new Dictionary<string, int>();
            foreach (var cola in Colas.AvailableFlavors)
            {
                sodas.Add(cola.GetType().Name, cola.Calories);
            }
            sodas.Add(LemonLime.GetType().Name, LemonLime.Calories);

            foreach (var rootbeer in RootBeers.AvailableFlavors)
            {
                sodas.Add(rootbeer.GetType().Name, rootbeer.Calories);
            }

            Console.WriteLine("Calories:");
            foreach (var soda in sodas)
            {
                Console.WriteLine(soda.Key +": " + soda.Value.ToString() + " calories.");
            }
        }
    }
}
