using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public enum TemperatureType
    {
        Fahrenheit,
        Celsius
    }
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    class MeatDatabase
    {
        // The (pretend) legacy API
        // Temps from http://www.foodsafety.gov/keep/charts/mintemp.html
        public float GetSafeCookTemp(string meat, TemperatureType tempType)
        {
            if (tempType == TemperatureType.Fahrenheit)
            {
                switch (meat)
                {
                    case "beef":
                    case "pork":
                        return 145f;

                    case "chicken":
                    case "turkey":
                        return 165f;

                    default:
                        return 165f;
                }
            }
            else
            {
                switch (meat)
                {
                    case "beef":
                    case "veal":
                    case "pork":
                        return 63f;

                    case "chicken":
                    case "turkey":
                        return 74f;

                    default:
                        return 74f;
                }
            }
        }

        public int GetCaloriesPerOunce(string meat)
        {
            switch (meat.ToLower())
            {
                case "beef": return 71;
                case "pork": return 69;
                case "chicken": return 66;
                case "turkey": return 38;
                default: return 0;
            }
        }

        public double GetProteinPerOunce(string meat)
        {
            switch (meat.ToLower())
            {
                case "beef": return 7.33f;
                case "pork": return 7.67f;
                case "chicken": return 8.57f;
                case "turkey": return 8.5f;
                default: return 0d;
            }
        }
    }

    /// <summary>
    /// The 'Target' class
    /// </summary>
    class Meat
    {
        protected string _meatName;
        protected float _safeCookTempFahrenheit;
        protected float _safeCookTempCelsius;
        protected double _caloriesPerOunce;
        protected double _proteinPerOunce;

        // Constructor
        public Meat(string meat)
        {
            this._meatName = meat;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nMeat: {0} ------ ", _meatName);
        }
    }

    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    class MeatDetails : Meat
    {
        private MeatDatabase _bank;

        // Constructor
        public MeatDetails(string name)
          : base(name)
        {
        }

        public override void Display()
        {
            // The Adaptee
            _bank = new MeatDatabase();

            _safeCookTempFahrenheit = _bank.GetSafeCookTemp(_meatName, TemperatureType.Fahrenheit);
            _safeCookTempCelsius = _bank.GetSafeCookTemp(_meatName, TemperatureType.Celsius);
            _caloriesPerOunce = _bank.GetCaloriesPerOunce(_meatName);
            _proteinPerOunce = _bank.GetProteinPerOunce(_meatName);

            base.Display();
            Console.WriteLine(" Safe Cook Temp (F): {0}", _safeCookTempFahrenheit);
            Console.WriteLine(" Safe Cook Temp (C): {0}", _safeCookTempCelsius);
            Console.WriteLine(" Calories per Ounce: {0}", _caloriesPerOunce);
            Console.WriteLine(" Protein per Ounce: {0}", _proteinPerOunce);
        }
    }
}
