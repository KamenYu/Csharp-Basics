using System;
namespace half_sum_elelment
{
    class Program
    {
        static void Main(string[] args)
        {
            // if you look for the min number of given values set the variable to the MAX of the variable OR the given MAX from the clue
            // if you look for the max number of given values set the variable to the MIN of the variable OR the given MIN from the clue

            // TODO check that because it is too late and I cannot think
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
           
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            int sumWithoutMaxNUmber = sum - max;
            if (max == sumWithoutMaxNUmber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMaxNUmber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }

        }
    }
}
