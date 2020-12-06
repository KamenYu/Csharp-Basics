using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int places = rows * columns;
            double price = 0.0;

            if (type =="Premiere")
            {
                price = places * 12;
            }
            else if (type == "Normal")
            {
                price = places * 7.5;
            }
            else if (type == "Discount")
            {
                price = places * 5.00;
            }
            Console.WriteLine($"{price:f2} leva");
        }
    }
}
