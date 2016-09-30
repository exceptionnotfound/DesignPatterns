using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// Our collection item.  Mostly because I'm a sucker for jelly beans.
    /// </summary>
    class JellyBean
    {
        private string _flavor;

        // Constructor
        public JellyBean(string flavor)
        {
            this._flavor = flavor;
        }

        
        public string Flavor
        {
            get { return _flavor; }
        }
    }

    /// <summary>
    /// The aggregate interface
    /// </summary>
    interface ICandyCollection
    {
        JellyBeanIterator CreateIterator();
    }

    /// <summary>
    /// The concrete aggregate class
    /// </summary>
    class JellyBeanCollection : ICandyCollection
    {
        private ArrayList _items = new ArrayList();

        public JellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }

        // Gets jelly bean count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }

    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    interface IJellyBeanIterator
    {
        JellyBean First();
        JellyBean Next();
        bool IsDone { get; }
        JellyBean CurrentBean { get; }
    }

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class JellyBeanIterator : IJellyBeanIterator
    {
        private JellyBeanCollection _jellyBeans;
        private int _current = 0;
        private int _step = 1;

        // Constructor
        public JellyBeanIterator(JellyBeanCollection beans)
        {
            this._jellyBeans = beans;
        }

        // Gets first jelly bean
        public JellyBean First()
        {
            _current = 0;
            return _jellyBeans[_current] as JellyBean;
        }

        // Gets next jelly bean
        public JellyBean Next()
        {
            _current += _step;
            if (!IsDone)
                return _jellyBeans[_current] as JellyBean;
            else
                return null;
        }

        // Gets current iterator candy
        public JellyBean CurrentBean
        {
            get { return _jellyBeans[_current] as JellyBean; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return _current >= _jellyBeans.Count; }
        }
    }
}
