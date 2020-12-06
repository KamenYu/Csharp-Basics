using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radians
{
    class Program
    {
        static void Main(string[] args)
        {
          double R = double.Parse(Console.ReadLine()); // number in radians
            double D = R * 180 / Math.PI;    // converting radians to degrees
            // number PI taken from the Math library
            Console.WriteLine(Math.Round(D)); // rounding with math round
            Console.ReadLine();

        }
    }
}
