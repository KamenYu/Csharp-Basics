using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //zooshop
            //"{крайната сума} lv."

            double dogs = double.Parse(Console.ReadLine());
            double dP = dogs * 2.50;
            double rest = double.Parse(Console.ReadLine());
            double restP = rest * 4;
            double sum = dP + restP;
            //math round + the name of the variable + the amount of numbers we want to round
            // but math round does not add extra zeros if needed
            //thus we need to use f2
            // double fin =  Math.Round(sum, 2);
            //when to the number in cw is added :f and a number (f3), the number is rounded until that (3)
            //but if there aren't any numbers zeros are added

            Console.WriteLine($"{sum:f2} lv.");
            Console.ReadLine();

        }
    }
}
