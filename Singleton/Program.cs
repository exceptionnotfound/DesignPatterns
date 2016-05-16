using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var theForce = TheForce.Instance;
            theForce.DisplayConnection();

            Console.ReadKey();
        }
    }
}
