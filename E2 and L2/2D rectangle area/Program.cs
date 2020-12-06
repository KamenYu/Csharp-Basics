using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine()); // deffining the coordinates
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double L = Math.Abs (x1 - x2); // sorting out the sides
            double W = Math.Abs(y1 - y2);  // getting the absolute values

            double area = L * W;
            double perimeter = 2 * (L + W);

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");
            Console.ReadLine();
        




        }
    }
}
