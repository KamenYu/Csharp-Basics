using System;
namespace fuel_tank_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бензин – 2.22 лева за един литър,
            //Дизел – 2.33 лева за един литър
            //Газ – 0.93 лева за литър
            //Ако водача има карта за отстъпки -18 ст.за литър бензин, -12 ст.за литър дизел и -8 ст.за литър газ.
            //Ако шофьорът е заредил между 20 и 25 литра включително, той получава 8 процента отстъпка от крайната цена, 
            //при повече от 25 литра гориво, той получава 10 процента отстъпка от крайната цена.

            //•	Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
            //•	Количество гориво – реално число в интервала[1.00 … 50.00]
            //•	Притежание на клубна карта – текст с възможности: "Yes" или "No"

            //•	"{крайната цена на горивото:f2} lv."

            string fuelType = Console.ReadLine();
            double l = int.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            double price1 = 0;
            double price2 = 0;

            if (clubCard == "Yes")
            {
                if (fuelType == "Gasoline")
                {
                    price1 = l * 2.22 - l * 0.18;
                    if (l >= 20 && l <= 25)
                    {                       
                        price2 = price1 - price1 * 0.08;
                    }
                    else if (l > 25)
                    {                        
                        price2 = price1 - price1 * 0.1;
                    }
                    else
                    {
                        price2 = price1;
                    }
                }
                else if (fuelType == "Gas")
                {
                    price1 = l * 0.93 - l * 0.08;
                    if (l >= 20 && l <= 25)
                    {                        
                        price2 = price1 - price1 * 0.08;
                    }
                    else if (l > 25)
                    {                        
                        price2 = price1 - price1 * 0.1;
                    }
                    else
                    {
                        price2 = price1;
                    }
                }
                else if (fuelType == "Diesel")
                {
                    price1 = l * 2.33 - l * 0.12;
                    if (l >= 20 && l <= 25)
                    {                        
                        price2 = price1 - price1 * 0.08;
                    }
                    else if (l > 25)
                    {
                        price2 = price1 - price1 * 0.1;
                    }
                    else
                    {
                        price2 = price1;
                    }
                }

            }
            else if (clubCard == "No")
            {
                if (fuelType == "Gasoline")
                {
                    price1 = l * 2.22;
                    if (l >= 20 && l <= 25)
                    {
                        price2 = price1 - price1 * 0.08;
                    }
                    else if (l > 25)
                    {
                        price2 = price1 - price1 * 0.1;
                    }
                    else
                    {
                        price2 = price1;
                    }
                }
                else if (fuelType == "Gas")
                {
                    price1 = l * 0.93;
                    if (l >= 20 && l <= 25)
                    {
                        price2 = price1 - price1 * 0.08;
                    }
                    else if (l > 25)
                    {
                        price2 = price1 - price1 * 0.1;
                    }
                    else
                    {
                        price2 = price1;
                    }
                }
                else if (fuelType == "Diesel")
                {
                    price1 = l * 2.33;
                    if (l >= 20 && l <= 25)
                    {
                        price2 = price1 - price1 * 0.08;
                    }
                    else if (l > 25)
                    {
                        price2 = price1 - price1 * 0.1;
                    }
                    else
                    {
                        price2 = price1;
                    }
                }
            }
            Console.WriteLine($"{price2:f2} lv.");
        }
    }
}
