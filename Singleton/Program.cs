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
            var bell = TheBell.Instance;
            bell.Ring();

            Console.ReadKey();
        }
    }
}
