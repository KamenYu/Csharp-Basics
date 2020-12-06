using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produce_market
{
    class Program
    {
        static void Main(string[] args)
        {
            double kgvP = double.Parse(Console.ReadLine()); //price of 1 kg of vegetables in lv
            double kgfP = double.Parse(Console.ReadLine()); //price of 1 kg of fruit in lv
            double allV = double.Parse(Console.ReadLine()); // all kg veg
            double allF = double.Parse(Console.ReadLine()); // all kg in fruit

            double income =( (kgvP * allV)+ (kgfP * allF)) / 1.94;
           

            Console.WriteLine($"{income:f2}");
          
            Console.ReadLine();
        }
    }
}
