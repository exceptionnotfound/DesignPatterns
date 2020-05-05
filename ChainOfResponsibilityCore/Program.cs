using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the chain links
            Approver jennifer = new HeadChef();
            Approver mitchell = new PurchasingManager();
            Approver olivia = new GeneralManager();

            //Create the chain
            jennifer.SetSupervisor(mitchell);
            mitchell.SetSupervisor(olivia);

            // Generate and process purchase requests
            PurchaseOrder p = new PurchaseOrder(1, 20, 69, "Spices");
            jennifer.ProcessRequest(p);

            p = new PurchaseOrder(2, 300, 1389, "Fresh Veggies");
            jennifer.ProcessRequest(p);

            p = new PurchaseOrder(3, 500, 4823.99, "Beef");
            jennifer.ProcessRequest(p);

            p = new PurchaseOrder(4, 4, 12099, "Ovens");
            jennifer.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
        }
    }
}
