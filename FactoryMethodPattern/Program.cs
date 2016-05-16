using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Starfighter> fighters = new List<Starfighter>();
            fighters.Add(new XWing());
            fighters.Add(new YWing());
            fighters.Add(new AWing());

            foreach(var starfighter in fighters)
            {
                Console.WriteLine("Craft: " + starfighter.GetType().Name + " ");
                foreach(var weapon in starfighter.Weapons)
                {
                    Console.WriteLine("Weapon: " + weapon.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
