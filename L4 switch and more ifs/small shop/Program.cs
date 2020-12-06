using System;
namespace small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //        coffee water beer sweets peanuts
            //  Sofia 0.50 0.80 1.20 1.45 1.60
            //Plovdiv 0.40 0.70 1.15 1.30 1.50
            //  Varna 0.45 0.70 1.10 1.35 1.55
           // Start:
            string good = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.00;

            if (city == "Sofia")
            {
                if (good == "coffee")
                {
                    price = 0.50;
                }
                else if (good == "water")
                {
                    price = 0.80;
                }
                else if (good == "beer")
                {
                    price = 1.20;
                }
                else if (good == "sweets")
                {
                    price = 1.45;
                }
                else if (good == "peanuts")
                {
                    price = 1.60;
                }

            }
            else if (city == "Plovdiv")
            {
                if (good == "coffee")
                {
                    price = 0.40;
                }
                else if (good == "water")
                {
                    price = 0.70;
                }
                else if (good == "beer")
                {
                    price = 1.15;
                }
                else if (good == "sweets")
                {
                    price = 1.30;
                }
                else if (good == "peanuts")
                {
                    price = 1.50;
                }
            }
            else if (city == "Varna")
            {
                if (good == "coffee")
                {
                    price = 0.45;
                }
                else if (good == "water")
                {
                    price = 0.70;
                }
                else if (good == "beer")
                {
                    price = 1.10;
                }
                else if (good == "sweets")
                {
                    price = 1.35;
                }
                else if (good == "peanuts")
                {
                    price = 1.55;
                }

                
            }

            double amountToPay = price * quantity;
            Console.WriteLine(amountToPay);
            //goto Start;

        }
    }
}
