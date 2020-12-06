using System;

namespace fishing_boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Цената зависи от сезона:
            //•	Цената за наем на кораба през пролетта е  3000 лв.
            //•	Цената за наем на кораба през лятото и есента е  4200 лв.
            //•	Цената за наем на кораба през зимата е  2600 лв.

            //В зависимост от броя си групата ползва отстъпка:
            //•	Ако групата е до 6 човека включително  –  отстъпка от 10 %.
            //•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            //•	Ако групата е от 12 нагоре  –  отстъпка от 25 %.

            //Рибарите ползват допълнително 5 % отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка, 
            //която се начислява след като се приспадне отстъпката по горните критерии.

            //Изход
            //Да се отпечата на конзолата един ред:
            //•	Ако бюджетът е достатъчен:
            //"Yes! You have {останалите пари} leva left."
            //•	Ако бюджетът НЕ Е достатъчен:
            //            "Not enough money! You need {сумата, която не достига} leva."
            //Сумите трябва да са форматирани с точност до два знака след десетичната запетая.
           // Start:
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());


            double discountedRent = 0.0;
            double ifSecondDiscount = 0.0;

            if (season == "Spring")
            {
                if (fishermen <= 6)
                {
                    discountedRent = 3000 - 3000 * 0.1;
                }
                else if (fishermen <= 11)
                {
                    discountedRent = 3000 - 3000 * 0.15;
                }
                else if (fishermen >= 12)
                {
                    discountedRent = 3000 - 3000 * 0.25;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (fishermen <= 6)
                {
                    discountedRent = 4200 - 4200 * 0.1;
                }
                else if (fishermen <= 11)
                {
                    discountedRent = 4200 - 4200 * 0.15;
                }
                else if (fishermen >= 12)
                {
                    discountedRent = 4200 - 4200 * 0.25;
                }
            }
            else if (season == "Winter")
            {
                if (fishermen <= 6)
                {
                    discountedRent = 2600 - 2600 * 0.1;
                }
                else if (fishermen <= 11)
                {
                    discountedRent = 2600 - 2600 * 0.15;
                }
                else if (fishermen >= 12)
                {
                    discountedRent = 2600 - 2600 * 0.25;
                }
            }

            if (fishermen % 2 == 0)
            {
                if (season == "Spring" || season == "Summer" || season == "Winter")
                {
                    ifSecondDiscount = discountedRent - discountedRent * 0.05;
                }          
                else
                {
                    ifSecondDiscount = discountedRent;
                }
            }
            else
            {
                ifSecondDiscount = discountedRent;
            }

            double final = Math.Abs(budget - ifSecondDiscount);

            if (budget >= ifSecondDiscount) // here was the mistake
            {
                Console.WriteLine($"Yes! You have {final:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {final:f2} leva.");
            }
           // goto Start;
        }
    }
}
