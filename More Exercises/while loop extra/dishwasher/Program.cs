using System;
namespace dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int detergentBottles = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();    // "End"   OR  int
            double totalDetergent = detergentBottles * 750;

            double totalPots = 0;
            double totalPlates = 0;
            int counter = 0;

            while (command != "End")
            {
                int dishesToBeWashed = int.Parse(command);
                counter++;
                if (counter % 3 == 0)
                {
                    totalDetergent -= dishesToBeWashed * 15;
                    totalPots += dishesToBeWashed;
                }
                else
                {
                    totalDetergent -= dishesToBeWashed * 5;
                    totalPlates += dishesToBeWashed;
                }
                if (totalDetergent < 0)
                {
                    double neededDetergent = Math.Abs(totalDetergent);
                    Console.WriteLine($"Not enough detergent, {neededDetergent} ml. more necessary!");
                    break;
                }              
                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{totalPlates} dishes and {totalPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {totalDetergent} ml.");
            }
        }
    }
}
