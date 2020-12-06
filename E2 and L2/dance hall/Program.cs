using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dance_hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine()); //in meters
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            // convert the meters into cm (*100)

            double hall = (L * 100)*(W * 100);
            double wardrobe = (A * A) * 10000;
            double bench = hall / 10;
            double area = hall - wardrobe - bench;
            double aD = area / (7000 + 40) ;

            Console.WriteLine(Math.Floor(aD)); //to round to the nearest number below
            //Math.Ceiling on the other hand round to the nearest number above
            Console.ReadLine();


        }
    }
}
