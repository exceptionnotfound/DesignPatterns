using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Sandwich { }

    abstract class Roast { }

    abstract class Dessert { }

    abstract class RecipeFactory
    {
        public abstract Sandwich CreateSandwich();
        public abstract Dessert CreateDessert();
    }

    class BLT : Sandwich { }

    class CremeBrulee : Dessert { }


    class AdultCuisineFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new BLT();
        }

        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }
    }

    class GrilledCheese : Sandwich { }

    class IceCreamSundae : Dessert { }

    class KidCuisineFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new GrilledCheese();
        }

        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }
    }
}
