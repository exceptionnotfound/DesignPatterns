using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a slider order using characters
            Console.WriteLine("Please enter your order (use characters A, B, Z with no spaces):");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            SliderFactory factory = new SliderFactory();

            // extrinsic state
            int orderTotal = 0;

            // For each character use a flyweight object
            foreach (char c in chars)
            {
                orderTotal++;
                Slider character = factory.GetCharacter(c);
                character.Display(orderTotal);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
