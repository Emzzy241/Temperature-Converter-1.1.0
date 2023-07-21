using System;
using System.Collections.Generic;

namespace TemperatureConverter.Models
{
    public class CelsiusToFahrenheit
    {

        public double StillConvertingCelsiusToFahrenheit{ get; set; }
        public double ConvertingCelsiusToFahrenheit{ get; set; }

        // The sementation fault(or NullRefernece Error that I was having) was really because I did not reinstantiate my CelsiusToFahrenheit() list inside the private list I created(_fourthINstance )
        // Remember the purpose of the list is to be able to add the 2 values that will be required for a temperature coversion to take place
        // My big mistake was trying to access an object(CelsiusToFahrenheit) with a list without being properly initialized
        private static List<CelsiusToFahrenheit> _fourthInstance = new List<CelsiusToFahrenheit>();
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