using System;
using System.Collections.Generic;

// I created a new class just so I can be able to differentiate the KelvinToCelsius class and the CelsiusTOKelvin class files

// Here I would be taking in a Celsius Temperature from my user and converting it into a Kelvin Temperature
// This would basically just be like the opposite of what we did in the KelvinToCelsius c-sharp file

namespace TemperatureConverter.Models
{
    public class CelsiusToKelvin
    {
        public double StillConvertingCelsiusToKelvin { get; set; }
        public double ConvertingCelsiusToKelvin { get; set; }

        private static List<CelsiusToKelvin> _secondInstances = new List<CelsiusToKelvin>();

        public List<CelsiusToKelvin> ForMyListOfCelsiusTemperature
        {
            get { return _secondInstances; }
            set { _secondInstances = value; }
        }

        public CelsiusToKelvin(double celsiusTemperature, double standardOfCelsiusToKelvin)
        {
            StillConvertingCelsiusToKelvin = celsiusTemperature;
            ConvertingCelsiusToKelvin = standardOfCelsiusToKelvin;
            _secondInstances.Add(this);
        }

        public double CelConverterMethod()
        {
            if((StillConvertingCelsiusToKelvin < 0) && (ConvertingCelsiusToKelvin == 273.15)){
                throw new ArgumentException("Invalid temperature in kelvin");
            }
            
            else{
                double finalCelsiusValue = StillConvertingCelsiusToKelvin + ConvertingCelsiusToKelvin;
                return finalCelsiusValue;
            }
        }
    }
}