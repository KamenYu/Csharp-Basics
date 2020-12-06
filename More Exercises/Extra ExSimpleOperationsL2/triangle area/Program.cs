using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine()); //side of a triangle
          
            double h = double.Parse(Console.ReadLine()); // height of a triangle

            double area = (a * h) / 2;

            Console.WriteLine($"{area:f2}");
            Console.ReadLine();
        }
    }
}
