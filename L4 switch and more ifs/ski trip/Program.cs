using System;

namespace ski_trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //          room for one person – 18.00 лв за нощувка
            //apartment – 25.00 лв 
            //president apartment – 35.00 лв

            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string assessment = Console.ReadLine();

            int nights = days - 1;

            double discount = 0.0;
            double price = 0.0;

            if (typeOfRoom == "apartment")
            {
                if (nights < 10)
                {
                    price = nights * 25;
                    discount = price * 0.3;
                }
                else if (nights <=15)
                {
                    price = nights * 25;
                    discount = price * 0.35;
                }
                else if (nights > 15)
                {
                    price = nights * 25;
                    discount = price * 0.5;
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                if (nights < 10)
                {
                    price = nights * 35;
                    discount = price * 0.1;
                }
                else if (nights <= 15)
                {
                    price = nights * 35;
                    discount = price * 0.15;
                }
                else if (nights > 15)
                {
                    price = nights * 35;
                    discount = price * 0.2;
                }
            }
            else if (typeOfRoom == "room for one person")
            {
                price = nights * 18;
            }

            double total = price - discount;
            double final = 0.0;

            if (assessment == "positive")
            {
                final = total + (0.25 * total);
            }
            else if (assessment == "negative")
            {
                final = total - (total * 0.1);
            }

            Console.WriteLine($"{final:f2}");
        }


    }
}
