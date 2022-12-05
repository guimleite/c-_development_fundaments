using System;
using MyUtilities;

namespace MyFirstProgram
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            // Showing a list of citys and them comfort index:
            Console.WriteLine("Where should e go in May?");
            WeatherUtilities.Report("San Francisco",WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(77), 55);
            MyUtilities.WeatherUtilities.Report("Bologna", 23, 65); // ~73 F
        }
    }
}