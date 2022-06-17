using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32.00) * (5.00 / 9.00);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9.00 / 5.00) + 32.00;
        }
    }
}
