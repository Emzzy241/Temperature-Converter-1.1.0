// This is the class file for the conversion of Fahrenheit to Celsius Temperature

using System;
using System.Collections.Generic;


// a method that takes in a fahrenheit Temperature and converts to celsius temperature

namespace TemperatureConverter.Models
{


    public class FahrenheitToCelsius
    {
        public double StillConvertingFahrenheitToCelsius { get; set; }
        public double ConvertingFahrenheitToCelsius { get; set; }

        private static List<FahrenheitToCelsius> _thirdInstances = new List<FahrenheitToCelsius>();

        public List<FahrenheitToCelsius> ForMyFahrenheitToCelsiusTemperatureList
        {
            get { return _thirdInstances; }
            set { _thirdInstances = value; }
        }

        // my constructor that helps me to handle the different C# properties I've written

        public FahrenheitToCelsius(double fahrenheitTemperature, double standardOfFahrenheitoCelsius)
        {
            StillConvertingFahrenheitToCelsius = fahrenheitTemperature;
            ConvertingFahrenheitToCelsius = standardOfFahrenheitoCelsius;
            _thirdInstances.Add(this);
        }

        public double FahrenheitConverterMethod()
        {


            // how a Fahrenheit Temperature is converted into a celsius on


            if ((StillConvertingFahrenheitToCelsius < 0))
            {
                throw new ArgumentException("Invalid temperature in kelvin");
            }
            else
            {
                double finalFahrenheitValue = (StillConvertingFahrenheitToCelsius - ConvertingFahrenheitToCelsius) * 0.56;
                // double finalFahrenheitValue = StillConvertingFahrenheitToCelsius + realConversion;
                return finalFahrenheitValue;
            }
        }


    }


}

