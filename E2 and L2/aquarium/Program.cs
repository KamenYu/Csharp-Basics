using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    class Program
    {
        static void Main(string[] args)
        {

            //aquarium
            double a = double.Parse(Console.ReadLine()); // lenght
            double b = double.Parse(Console.ReadLine());  // width
            double h = double.Parse(Console.ReadLine());  // height
            double pr = double.Parse(Console.ReadLine());  // percent of stuff in the aquarium

            double V = a * b * h; // volume in cubic cm
            double vDM = V * 0.001; // volume in cubic dm
            double pP = pr * 0.01;   // double made into a percent
            double Fin = vDM * (1 - pP); // final volume in cubic dm
            // times 1 minus the amount of stuff in the aquarium

            Console.WriteLine($"{Fin:f3}");

            Console.ReadLine();

        }
    }
}
