using System;
namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int flowers = int.Parse(Console.ReadLine());

            double honey = bees * flowers * 0.21;
            double honeyCombs = Math.Floor(honey / 100);
            double honeyCombsInG = honeyCombs * 100;
            double rest = honey - honeyCombsInG;

            Console.WriteLine($"{honeyCombs} honeycombs filled.");
            Console.WriteLine($"{rest:f2} grams of honey left.");
        }
    }
}
