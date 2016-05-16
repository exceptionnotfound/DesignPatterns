using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Starfighter { }

    abstract class CapitalShip { }

    abstract class SuperWeapon { }

    abstract class StarshipFactory
    {
        public abstract Starfighter CreateStarfighter();
        public abstract CapitalShip CreateCapitalShip();
    }

    class TIEFighter : Starfighter { }

    class StarDestroyer : CapitalShip { }


    class EmpireFactory : StarshipFactory
    {
        public override Starfighter CreateStarfighter()
        {
            return new TIEFighter();
        }

        public override CapitalShip CreateCapitalShip()
        {
            return new StarDestroyer();
        }
    }

    class XWing : Starfighter { }

    class MonCalamariCruiser : CapitalShip { }

    class RebellionFactory : StarshipFactory
    {
        public override Starfighter CreateStarfighter()
        {
            return new XWing();
        }

        public override CapitalShip CreateCapitalShip()
        {
            return new MonCalamariCruiser();
        }
    }
}
