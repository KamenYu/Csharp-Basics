using System;
namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            // 78 from 100

            double honey = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();  // name or command          
            double rest = 0;
            double total = 0;

            while (command != "Winter has come")
            {
               double gatheredHForSixMonths = 0;

                for (int i = 1; i <= 6; i++)
                {
                    double gatheredHoneyPerMonth = double.Parse(Console.ReadLine());
                    gatheredHForSixMonths += gatheredHoneyPerMonth;
                }
                total += gatheredHForSixMonths;
                rest = Math.Abs(honey - total);
                if (total > honey)
                {
                    Console.WriteLine($"Well done! Honey surplus {rest:f2}.");
                    break;
                }
                if (gatheredHForSixMonths < 0)
                {
                    Console.WriteLine($"{command} was banished for gluttony");
                }
                command = Console.ReadLine();
            }
            
            if (command == "Winter has come")
            {
                if (total <= honey)
                {
                    Console.WriteLine($"Hard Winter! Honey needed {rest:f2}.");
                }
                else
                {
                    Console.WriteLine($"Well done! Honey surplus {rest:f2}.");
                }
            }
        }
    }
}
