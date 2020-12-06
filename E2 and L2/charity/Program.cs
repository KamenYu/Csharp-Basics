using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charity
{
    class Program
    {
        static void Main(string[] args)
        {

          double dOC = double.Parse(Console.ReadLine()); //days of campaign
          double aOB = double.Parse(Console.ReadLine()); // amount of bakers
          double c = double.Parse(Console.ReadLine()); // amount of cakes
          double w = double.Parse(Console.ReadLine()); // ampount of waffles
          double p = double.Parse(Console.ReadLine()); //amount of pancakes

            double cM = c * 45; //cake money
            double wM = w * 5.8; // waffle money
            double pM = p * 3.2; // pancake money    

          double mPB = (cM + wM + pM) * aOB; // money per bakers
       
          double mPD = mPB * dOC;
          double mMD = mPD - mPD / 8; // money minus the deductions

          Console.WriteLine($"{mMD:f2}");
          Console.ReadLine();




        }
    }
}
