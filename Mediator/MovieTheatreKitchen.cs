using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// The Mediator interface, which defines a send message method which the concrete mediators must implement.
    /// </summary>
    interface Mediator
    {
        void SendMessage(string message, Kitchen kitchen);
    }

    /// <summary>
    /// The Concrete Mediator class, which implement the send message method and keep track of all participants in the conversation.
    /// </summary>
    class KitchenMediator : Mediator
    {
        private LeftSideKitchen _leftKitchen;
        private RightSideKitchen _rightKitchen;

        public LeftSideKitchen LeftKitchen
        {
            set { _leftKitchen = value; }
        }

        public RightSideKitchen RightKitchen
        {
            set { _rightKitchen = value; }
        }

        public void SendMessage(string message, Kitchen colleague)
        {
            if (colleague == _leftKitchen)
            {
                _rightKitchen.Notify(message);
            }
            else
            {
                _leftKitchen.Notify(message);
            }
        }
    }

    /// <summary>
    /// The Colleague abstract class, representing an entity involved in the conversation which should receive messages.
    /// </summary>
    abstract class Kitchen
    {
        protected Mediator mediator;

        // Constructor
        public Kitchen(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    class LeftSideKitchen : Kitchen
    {
        // Constructor
        public LeftSideKitchen(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Console.WriteLine("Left Side Kitchen sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Left Side Kitchen gets message: "  + message);
        }
    }

    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    class RightSideKitchen : Kitchen
    {
        public RightSideKitchen(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Console.WriteLine("Right Side Kitchen sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Right Side Kitchen gets message: " + message);
        }
    }
}
