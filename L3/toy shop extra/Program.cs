using System;

namespace toy_shop_extra
{
    class Program
    {
        static void Main(string[] args)
        { 
            double eP = double.Parse(Console.ReadLine()); // excursion money output
            int aP = int.Parse(Console.ReadLine());// amount of puzzles
            int aTD = int.Parse(Console.ReadLine()); // talking dolls amount
            int atB = int.Parse(Console.ReadLine()); // amount teddy bears
            int aM = int.Parse(Console.ReadLine()); // amount minions
            int aT = int.Parse(Console.ReadLine()); // amount trucks

            int allT = aP + aTD + atB + aM + aT;
            double profit = aP * 2.6 + aTD * 3 + atB * 4.1 + aM * 8.2 + aT * 2;
            
            if (allT >= 50)
            {
                profit = profit * 0.75;
            }

            profit = profit * 0.9;

            double diff = Math.Abs(eP - profit);
            
            if (profit >= eP)
            {
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diff:f2} lv needed.");
            }

            
        }
    }
}
