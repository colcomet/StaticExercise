using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"46f = {TempConverter.FahrenheitToCelsius(46):0.0}c");
            Console.WriteLine($"102f = {TempConverter.FahrenheitToCelsius(102):0.0}c");
            Console.WriteLine($"4f = {TempConverter.FahrenheitToCelsius(4):0.0}c");

            Console.WriteLine($"38c = {TempConverter.CelsiusToFahrenheit(38):0.0}f");
            Console.WriteLine($"-12c = {TempConverter.CelsiusToFahrenheit(-12):0.0}f");
            Console.WriteLine($"17c = {TempConverter.CelsiusToFahrenheit(17):0.0}f");
        }
    }
}
