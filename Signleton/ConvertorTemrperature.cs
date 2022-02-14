using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // In Static classes you do not need to create an instance.
    // This class is going to calculate the temperature in Fahrenheit and celcius
    public static class ConvertorTemrperature
    {
        // This method convert celcius to fahrenheit
        public static double ToFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
        // This method convert fahrenheit to celcius
        public static double ToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
