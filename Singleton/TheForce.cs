using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public sealed class TheForce
    {
        private static TheForce forceConnection;
        private static object syncRoot = new Object();
        private TheForce()
        {

        }

        /// <summary>
        /// We implement this method to ensure thread safety for our singleton.
        /// </summary>
        public static TheForce Instance
        {
            get
            {
                lock(syncRoot)
                {
                    if(forceConnection == null)
                    {
                        forceConnection = new TheForce();
                    }
                }

                return forceConnection;
            }
        }

        public void DisplayConnection()
        {
            Console.WriteLine("Use the Force, Luke!");
        }
    }
}
