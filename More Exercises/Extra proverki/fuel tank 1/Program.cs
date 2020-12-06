using System;
namespace fuel_tank_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //на първия ред се чете типа на горивото – текст с възможности: "Diesel", "Gasoline" или "Gas", 
            //а на втория литрите гориво, които има в резервоара. 
            //Ако литрите гориво са повече или равни на 25, на конзолата да се отпечата "You have enough {fuel}.",
            //ако са по - малко от 25, да се отпечата "Fill your tank with {fuel}!".
            //В случай, че бъде въведено гориво, различно от посоченото, да се отпечата "Invalid fuel!".

            string fuel = Console.ReadLine();
            int l = int.Parse(Console.ReadLine());

            if (fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas")
            {
                if (l >= 25)
                {
                    Console.WriteLine($"You have enough {fuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
