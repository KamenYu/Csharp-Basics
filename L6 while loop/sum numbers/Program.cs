using System;

namespace sum_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();    // type a number
            int sum = 0;

            while (input != "Stop")                  // || until you write Stop
            {
                int numSum = int.Parse(input);       // convert the number to int
                sum += numSum;                       // sum the current numbers
                input = Console.ReadLine();          // type another number ||
            }
            Console.WriteLine(sum);
        }
    }
}
