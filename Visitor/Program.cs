using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        /// <summary>
        /// The Visitor pattern represents an operation to be performed on the elements of an object structure.
        /// Whereas Strategy exposes items to a standardized interface, Visitor details a mechanism by which
        /// objects can accept a reference to another object (the visitor) which exposes an interface that the target
        /// can call upon itself.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Who are my employees?
            Employees e = new Employees();
            e.Attach(new LineCook());
            e.Attach(new HeadChef());
            e.Attach(new GeneralManager());

            // Employees are visited, giving them 10% raises and 3 extra paid time off days.
            e.Accept(new IncomeVisitor());
            e.Accept(new PaidTimeOffVisitor());

            Console.ReadKey();
        }
    }
}
