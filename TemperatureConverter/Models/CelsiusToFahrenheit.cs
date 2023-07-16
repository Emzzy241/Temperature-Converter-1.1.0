using System;
using System.Collections.Generic;

namespace TemperatureConverter.Models
{
    public class CelsiusToFahrenheit
    {

        public double StillConvertingCelsiusToFahrenheit{ get; set; }
        public double ConvertingCelsiusToFahrenheit{ get; set; }

        private static List<CelsiusToFahrenheit> _fourthInstance;
        public List<CelsiusToFahrenheit> ForMyListOfCelsiusToFahreheitTemperatures
        {
            get { return _fourthInstance; }
            set { _fourthInstance = value; }
        }

        public CelsiusToFahrenheit(double mySecondFahrenheitTemp, double standardOfFahrenheitTemp)
        {
            StillConvertingCelsiusToFahrenheit = mySecondFahrenheitTemp;
            ConvertingCelsiusToFahrenheit = standardOfFahrenheitTemp;
            _fourthInstance.Add(this);
        }

        public double SecondFahrenheitConverterMethod()
        {
            // how a temperature in Celsius is converted to one in Fahrenheit

        
            if((StillConvertingCelsiusToFahrenheit < 0))
            {
                throw new ArgumentException("Invalid temperature value");
            }
            else{
                double finalCelsiusToFahrenheitTemperature = (StillConvertingCelsiusToFahrenheit * 1.8) +32;
                return finalCelsiusToFahrenheitTemperature;
            }
        }


    }
}