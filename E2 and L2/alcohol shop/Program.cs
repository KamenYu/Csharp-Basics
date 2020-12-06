using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alcohol_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum of all alcohols in price per litre


            double wLv = double.Parse(Console.ReadLine()); //wiskey price per litre
            double bL = double.Parse(Console.ReadLine()); // litres beer
            double wL = double.Parse(Console.ReadLine()); // wine litres
            double rL = double.Parse(Console.ReadLine()); // rakiya litres
            double wLit = double.Parse(Console.ReadLine()); // wiskey litres

            double wA = wLv * wLit; // wiskey amount
            double rP = wLv / 2; //rakiya price
            double wineP = rP - (0.4 * rP) ; // 0.4 * rakiya price gives me 40 % of the price
            // deducting rP - 40% gives me wine price
            double bP = rP - (0.8 * rP); //same but for beer price

            double rA = rP * rL; // rakiya amount
            double wineA = wineP * wL;
            double bA = bP * bL;

            double sum = wA + rA + wineA + bA;

            Console.WriteLine($"{sum:f2}");
            Console.ReadLine();



        }
    }
}
