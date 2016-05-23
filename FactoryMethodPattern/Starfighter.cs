using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Product
    /// </summary>
    abstract class Ingredient { }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class Bread : Ingredient
    {

    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class Turkey : Ingredient
    {

    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class Lettuce : Ingredient
    {

    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class Mayonnaise : Ingredient
    {

    }


    /// <summary>
    /// Creator
    /// </summary>
    abstract class Recipe
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Recipe()
        {
            CreateIngredients();
        }

        //Factory method
        public abstract void CreateIngredients();

        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
        }
    }

    /// <summary>
    /// ConcreteCreator
    /// </summary>
    class TurkeySandwich : Recipe
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
        }
    }

    /// <summary>
    /// ConcreteCreator
    /// </summary>
    class Dagwood : Recipe
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
        }
    }
}
