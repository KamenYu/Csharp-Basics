using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_paint
{
    class Program
    {
        static void Main(string[] args)
        {
           

            double x = double.Parse(Console.ReadLine()); 
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

           
            double back = x * x;
            double front = back - 2.4;
            double sides = 2 * (x * y) - 2 * (1.5 * 1.5);
            double greenDyeL = (front + back + sides) / 3.4;

            double roofT = x * h;

            double roofS = 2 * (x * y);
            double redDyeL = (roofT + roofS) / 4.3;
           

            Console.WriteLine($"{greenDyeL:f2}");
            Console.WriteLine($"{redDyeL:f2}");
            Console.ReadLine();

            



        }
    }
}
