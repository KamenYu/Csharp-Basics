using System;

namespace transport_price
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
            //•	Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
            //•	Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price = 0;

            if (km < 20) // taxi
            {
                if (time == "day")
                {
                    price = 0.7 + (0.79 * km);
                }
                else
                {
                    price = 0.7 + (0.9 * km);
                }
            }
            else if (km >= 20 && km <=99)
            {
                price = km * 0.09;
            }
            else if (km >= 100)
            {
                price = km * 0.06;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
