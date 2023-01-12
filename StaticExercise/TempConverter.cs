using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
       public static double CelsiusToFahrenheit(double c)
        {
            double cConversion = (1.8 * c) + 32;
            return cConversion;
        }

        public static double FahrenheitToCelsius(double f)
        {
            double fConversion = (f - 32) / 1.8;
            return fConversion;
        }
    }
}
