using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsius_to_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //T(°F) = 20°C × 9/5 + 32 = 68 °F
            double C = double.Parse(Console.ReadLine());

            double F = (C * 9/5) + 32;

            Console.WriteLine($"{F:f2}");


            
        }
    }
}
