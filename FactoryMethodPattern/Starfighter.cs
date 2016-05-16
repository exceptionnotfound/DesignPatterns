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
    abstract class Weapon { }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class LaserCannon : Weapon
    {

    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class ProtonTorpedoLauncher : Weapon
    {

    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class IonCannon : Weapon
    {

    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class ConcussionMissile : Weapon
    {

    }


    /// <summary>
    /// Creator
    /// </summary>
    abstract class Starfighter
    {
        private List<Weapon> _weapons = new List<Weapon>();

        public Starfighter()
        {
            CreateWeapons();
        }

        //Factory method
        public abstract void CreateWeapons();

        public List<Weapon> Weapons
        {
            get { return _weapons; }
        }
    }

    /// <summary>
    /// ConcreteCreator
    /// </summary>
    class XWing : Starfighter
    {
        public override void CreateWeapons()
        {
            Weapons.Add(new LaserCannon());
            Weapons.Add(new LaserCannon());
            Weapons.Add(new LaserCannon());
            Weapons.Add(new LaserCannon());
            Weapons.Add(new ProtonTorpedoLauncher());
            Weapons.Add(new ProtonTorpedoLauncher());
        }
    }

    /// <summary>
    /// ConcreteCreator
    /// </summary>
    class YWing : Starfighter
    {
        public override void CreateWeapons()
        {
            Weapons.Add(new LaserCannon());
            Weapons.Add(new LaserCannon());
            Weapons.Add(new ProtonTorpedoLauncher());
            Weapons.Add(new ProtonTorpedoLauncher());
            Weapons.Add(new IonCannon());
            Weapons.Add(new IonCannon());
        }
    }

    /// <summary>
    /// ConcreteCreator
    /// </summary>
    class AWing : Starfighter
    {
        public override void CreateWeapons()
        {
            Weapons.Add(new LaserCannon());
            Weapons.Add(new LaserCannon());
            Weapons.Add(new ConcussionMissile());
            Weapons.Add(new ConcussionMissile());
        }
    }
}
