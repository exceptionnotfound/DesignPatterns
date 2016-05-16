using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you? (R)ebellion or (E)mpire?");
            char input = Console.ReadKey().KeyChar;
            StarshipFactory factory;
            switch(input)
            {
                case 'E':
                    factory = new EmpireFactory();
                    break;

                case 'R':
                    factory = new RebellionFactory();
                    break;

                default:
                    throw new NotImplementedException();

            }

            var fighter = factory.CreateStarfighter();
            var capitalShip = factory.CreateCapitalShip();

            Console.WriteLine("\nFighter: " + fighter.GetType().Name);
            Console.WriteLine("Capital Ship: " + capitalShip.GetType().Name);

            Console.ReadKey();
        }
    }
}
