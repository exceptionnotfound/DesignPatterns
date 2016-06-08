using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// The Prototype abstract class
    /// </summary>
    abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }

    class Sandwich : SandwichPrototype
    {
        private string Bread;
        private string Meat;
        private string Cheese; //I will use this pun everywhere I can
        private string Veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            Bread = bread;
            Meat = meat;
            Cheese = cheese;
            Veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            string ingredientList = GetIngredientList();
            Console.WriteLine("Cloning sandwich with ingredients: {0}", ingredientList.Remove(ingredientList.LastIndexOf(",")));

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientList()
        {
            var ingredientList = "";
            if (!string.IsNullOrWhiteSpace(Bread))
            {
                ingredientList += Bread + ", ";
            }
            if (!string.IsNullOrWhiteSpace(Meat))
            {
                ingredientList += Meat + ", ";
            }
            if (!string.IsNullOrWhiteSpace(Cheese))
            {
                ingredientList += Cheese + ", ";
            }
            if (!string.IsNullOrWhiteSpace(Veggies))
            {
                ingredientList += Veggies + ", ";
            }
            return ingredientList;
        }
    }

    class SandwichMenu
    {
        private Dictionary<string, SandwichPrototype> _sandwiches = new Dictionary<string, SandwichPrototype>();

        public SandwichPrototype this[string name]
        {
            get { return _sandwiches[name]; }
            set { _sandwiches.Add(name, value); }
        }
    }
}
