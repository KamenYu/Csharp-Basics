using System;

namespace godzilla_vs_kong
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Декорът за филма е на стойност 10 % от бюджета.
            // При повече от 150 статиста, има отстъпка за облеклото на стойност 10 %.

            //            Ако парите за декора и дрехите са повече от бюджета:
            //Not enough money!
            //            Wingard needs { парите недостигащи за филма}
            //            leva more.
            //      Ако парите за декора и дрехите са по малко или равни на бюджета:
            //            Action!;
            //            Wingard starts filming with { останалите пари}
            //            leva left.

            double budget = double.Parse(Console.ReadLine());
            int statN = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());
            double dekor = budget * 0.1;

            if (statN >= 150)
            {
                clothing = clothing - (clothing * 0.1);
            }

            double clothingMoney = statN * clothing;
            double movieMoney = clothingMoney + dekor;
            double leftMoney = Math.Abs(budget- movieMoney);

            if (movieMoney > budget )
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {leftMoney:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left." );
            }





        }
    }
}
