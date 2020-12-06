using System;
namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolia = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double present = double.Parse(Console.ReadLine());

            double sum = magnolia * 3.25 + hyacinth * 4 + roses * 3.5 + cactuses * 8;
            double fiskFreeSum = sum - sum * 0.05;

            double diff = Math.Abs(fiskFreeSum - present);

            if (fiskFreeSum >= present)
            {
                Console.WriteLine($"She is left with {Math.Floor(diff)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(diff)} leva.");
            }

        }
    }
}
