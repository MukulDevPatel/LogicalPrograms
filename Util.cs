using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Util
    {
        public static void temperaturConversion()
        {
            Console.WriteLine("Convert temperature unit");
            Console.WriteLine("Enter a Celsius input");
            double temperature = Convert.ToDouble(Console.ReadLine());
            double result = (temperature * 9 / 5) + 32;
            Console.WriteLine("Celsius into Fahrenheit: " + result+ "ºF");

            Console.WriteLine("Enter Fahrenheit input");
            double temperature1 = Convert.ToDouble(Console.ReadLine());
            double result1 = (temperature1 - 32) * 5 / 9;
            Console.WriteLine("Fahrenheit into Celsius: " + result1+ "ºC");
        }
    }
}
