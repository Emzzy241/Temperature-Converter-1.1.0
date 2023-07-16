using System;
using System.Collections.Generic;

namespace TemperatureConverter.Models
{
    public class KelvinToFahrenheit
    {
        public double StillConvertingKelvinToFahrenheit { get; set; }
        public double ConvertingKelvinToFahrenheit { get; set; }

        private static List<KelvinToFahrenheit> _sixthInstance  = new List<KelvinToFahrenheit>();

        public List<KelvinToFahrenheit> ForMySecondFahrenheitTemperatureList
        {
            get { return _sixthInstance; }
            set { _sixthInstance = value; }
        }

        public KelvinToFahrenheit(double myKelvinTemperature, double myStandardsOfTemperature)
        {
            StillConvertingKelvinToFahrenheit = myKelvinTemperature;
            ConvertingKelvinToFahrenheit = myStandardsOfTemperature;
            _sixthInstance.Add(this);
        }

        public double SecondKelvinToFahrenheitConverterMethod()
        {
            // double trueConversion = (ConvertingKelvinToFahrenheit - 273.15) * 1.8 + 32;
            if((StillConvertingKelvinToFahrenheit < 0))
            {
                throw new ArgumentException("Invalid temperature value");
            }
            else{
                double finalKelvinToFahrenheitTemperature = (ConvertingKelvinToFahrenheit - 273.15) * 1.8 + 32;
                return finalKelvinToFahrenheitTemperature;
            }
            // I have successfully been able to handle the business logic, now its time for UI logic
        }

    }
}