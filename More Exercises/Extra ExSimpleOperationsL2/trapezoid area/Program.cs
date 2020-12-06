using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trapezoid_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine()); //bottom of trapezoid
            double b2 = double.Parse(Console.ReadLine()); // above of trapezoid
            double h = double.Parse(Console.ReadLine()); // height of trapezoid

            double area = (b1 + b2) * h/2;

            Console.WriteLine($"{area:f2}");
            Console.ReadLine();

        }
    }
}
