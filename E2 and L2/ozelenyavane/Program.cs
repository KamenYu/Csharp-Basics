using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozelenyavane
{
    class Program
    {
        static void Main(string[] args)
        {
            //ozelenyavane
            //sq m, sq m price 7.61
            // discount 18%
            double sqM = double.Parse(Console.ReadLine());
            double sqMP = sqM * 7.61;
            double discount = 0.18 * sqMP;
            double fP = sqMP - discount;

            Console.WriteLine($"The final price is: {fP:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");

            Console.ReadLine();

        }
    }
}
