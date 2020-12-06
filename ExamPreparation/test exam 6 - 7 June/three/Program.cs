using System;
namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Season      Sunflower   Daisy     Lavender    Mint
            //Spring          10         12        12          10
            //Summer           8          8         8          12
            //Autumn           12         6         6            6


            //•	Ако сезонът е "Autumn", кошерът произвежда 5 % по - малко мед.


            string flowerType = Console.ReadLine();                         //"Sunflower", "Daisy", "Lavender", "Mint"
            int flowerAmount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();                            //"Spring", "Summer", "Autumn"
            double honey = 0;

            if (season == "Spring")
            {
                if (flowerType == "Sunflower")
                {
                    honey = flowerAmount * 10;
                }
                else if (flowerType == "Daisy")
                {
                    honey = (flowerAmount * 12) + (flowerAmount * 12 * 0.1);
                }
                else if (flowerType == "Lavender")
                {
                    honey = flowerAmount * 12;
                }
                else if (flowerType == "Mint")
                {
                    honey = (flowerAmount * 10) + (flowerAmount * 10 * 0.1);
                }
            }
            else if (season == "Summer")
            {
                if (flowerType == "Sunflower")
                {
                    honey = (flowerAmount * 8) + (flowerAmount * 8 * 0.1);
                }
                else if (flowerType == "Daisy")
                {
                    honey = (flowerAmount * 8) + (flowerAmount * 8 * 0.1);
                }
                else if (flowerType == "Lavender")
                {
                    honey = (flowerAmount * 8) + (flowerAmount * 8 * 0.1);
                }
                else if (flowerType == "Mint")
                {
                    honey = (flowerAmount * 12) + (flowerAmount * 12 * 0.1);
                }
            }
            else if (season == "Autumn")
            {
                if (flowerType == "Sunflower")
                {
                    honey = (flowerAmount * 12) - (flowerAmount * 12 * 0.05);
                }
                else if (flowerType == "Daisy")
                {
                    honey = (flowerAmount * 6) - (flowerAmount * 6 * 0.05);
                }
                else if (flowerType == "Lavender")
                {
                    honey = (flowerAmount * 6) - (flowerAmount * 6 * 0.05);
                }
                else if (flowerType == "Mint")
                {
                    honey = (flowerAmount * 6) - (flowerAmount * 6 * 0.05);
                }
            }
            //"Total honey harvested: {honey:f2}"
            
            Console.WriteLine($"Total honey harvested: {honey:f2}");
        }
    }
}
