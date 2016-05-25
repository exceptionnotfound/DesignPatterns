using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        /// <summary>
        /// The Template Method pattern allows an abstract to define the skeleton or outline of an algorithm,
        /// but leave the implementation of the individual steps in that algorithm up to the deriving classes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            sourdough.Make();

            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();

            Console.ReadKey();
        }
    }
}
