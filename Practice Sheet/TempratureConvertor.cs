using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class TempratureConvertor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter celsius");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius to fahrenheit is: "); celsiusTofahren(celsius);
            Console.WriteLine("Enter Fahrenheit");
            double fahren = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit to Celsius is: "); fahrenTocelsius(fahren);
        }
        static void celsiusTofahren(double celsius)
        {
            double fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine(fahrenheit);
        }
        static void fahrenTocelsius(double fahren)
        {
            double celsius = ((fahren - 32) * 5) /9;
            Console.WriteLine(celsius);
        }
    }
}
