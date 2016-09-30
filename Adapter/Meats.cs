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
    /// The legacy API which must be converted to the new structure (aka the Adaptee participant)
    /// </summary>
    class MeatDatabase
    {
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
    /// The Target participant, which represents details about a particular kind of meat.
    /// </summary>
    class Meat
    {
        protected string MeatName;
        protected float SafeCookTempFahrenheit;
        protected float SafeCookTempCelsius;
        protected double CaloriesPerOunce;
        protected double ProteinPerOunce;

        // Constructor
        public Meat(string meat)
        {
            this.MeatName = meat;
        }

        public virtual void LoadData()
        {
            Console.WriteLine("\nMeat: {0} ------ ", MeatName);
        }
    }

    /// <summary>
    /// The Adapter class, which wraps the Meat class and initializes that class's values.
    /// </summary>
    class MeatDetails : Meat
    {
        private MeatDatabase _meatDatabase;

        // Constructor
        public MeatDetails(string name)
          : base(name)
        {
        }

        public override void LoadData()
        {
            // The Adaptee
            _meatDatabase = new MeatDatabase();

            SafeCookTempFahrenheit = _meatDatabase.GetSafeCookTemp(MeatName, TemperatureType.Fahrenheit);
            SafeCookTempCelsius = _meatDatabase.GetSafeCookTemp(MeatName, TemperatureType.Celsius);
            CaloriesPerOunce = _meatDatabase.GetCaloriesPerOunce(MeatName);
            ProteinPerOunce = _meatDatabase.GetProteinPerOunce(MeatName);

            base.LoadData();
            Console.WriteLine(" Safe Cook Temp (F): {0}", SafeCookTempFahrenheit);
            Console.WriteLine(" Safe Cook Temp (C): {0}", SafeCookTempCelsius);
            Console.WriteLine(" Calories per Ounce: {0}", CaloriesPerOunce);
            Console.WriteLine(" Protein per Ounce: {0}", ProteinPerOunce);
        }
    }
}
