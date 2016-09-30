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
        void SendMessage(string message, ConcessionStand concessionStand);
    }

    /// <summary>
    /// The Concrete Mediator class, which implement the send message method and keep track of all participants in the conversation.
    /// </summary>
    class ConcessionsMediator : Mediator
    {
        private NorthConcessionStand _northConcessions;
        private SouthConcessionStand _southConcessions;

        public NorthConcessionStand NorthConcessions
        {
            set { _northConcessions = value; }
        }

        public SouthConcessionStand SouthConcessions
        {
            set { _southConcessions = value; }
        }

        public void SendMessage(string message, ConcessionStand colleague)
        {
            if (colleague == _northConcessions)
            {
                _southConcessions.Notify(message);
            }
            else
            {
                _northConcessions.Notify(message);
            }
        }
    }

    /// <summary>
    /// The Colleague abstract class, representing an entity involved in the conversation which should receive messages.
    /// </summary>
    abstract class ConcessionStand
    {
        protected Mediator mediator;

        public ConcessionStand(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    class NorthConcessionStand : ConcessionStand
    {
        // Constructor
        public NorthConcessionStand(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Console.WriteLine("North Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("North Concession Stand gets message: "  + message);
        }
    }

    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    class SouthConcessionStand : ConcessionStand
    {
        public SouthConcessionStand(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Console.WriteLine("South Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("South Concession Stand gets message: " + message);
        }
    }
}
