// This is the class file for the conversion of Fahrenheit to Kelvin Temperature


using System;
using System.Collections.Generic;


// // a method that takes in a fahrenheit Temperature and converts to celsius temperature

namespace TemperatureConverter.Models
{


    public class FahrenheitToKelvin
    {


        public double StillConvertingFahrenheitToKelvin { get; set; }
        public double ConvertingfahrenheitToKelvin { get; set; }


        private static List<FahrenheitToKelvin> _thirdInstances = new List<FahrenheitToKelvin>();

        public List<FahrenheitToKelvin> ForMyFahrenheitToCelsiusTemperatureList
        {
            get { return _thirdInstances; }
            set { _thirdInstances = value; }
        }

//         // my constructor that helps me to handle the different C# properties I've written

        public FahrenheitToKelvin(double fahrenheitTemperature, double standardOfFahrenheitoKelvin)
        {
            StillConvertingFahrenheitToKelvin = fahrenheitTemperature;
            ConvertingfahrenheitToKelvin = standardOfFahrenheitoKelvin;
            _thirdInstances.Add(this);
        }

        public double FahrenheitConverterMethod()
        {
            // how a fahrenheit Temperature is converted into a kelvin one
            double conversionStandard = ConvertingfahrenheitToKelvin - 32 * 0.56 + 273.15;

            if ((StillConvertingFahrenheitToKelvin < 0))
            {
                throw new ArgumentException("Invalid temperature in kelvin");
            }
            else{
                double finalFahrenheitValue = conversionStandard;
                return finalFahrenheitValue;
            }
        }


    }


}

