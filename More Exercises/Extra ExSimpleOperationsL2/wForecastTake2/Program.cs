using System;
namespace wForecastTake2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Градуси	Време
                    26.00 - 35.00	Hot      15.00 - 20.00	Mild     20.1 - 25.9	Warm        12.00 - 14.9 Cool                5.00 - 11.9	Cold*/
                Start:
            double tempetature = double.Parse(Console.ReadLine());
           if (tempetature <=5)
            {
                Console.WriteLine("unknown");
            }
            else if (tempetature <= 11.9)
            {
                Console.WriteLine("Cold");
            }
           else if (tempetature <= 14.9)
            {
                Console.WriteLine("Cool");
            }
           else if (tempetature <=20.00)
            {
                Console.WriteLine("Mild");
            }
           else if (tempetature <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (tempetature <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (tempetature >= 35.00)
            {
                Console.WriteLine("unknown");
            }
            else if (tempetature == 0.00)
            {
                Console.WriteLine("unknown");
            }
            goto Start;
            Console.ReadLine();

        }
    }
}
