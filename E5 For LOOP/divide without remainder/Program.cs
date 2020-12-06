using System;
namespace divide_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {

            // if you look for the min number of given values set the variable to the MAX of the variable OR the given MAX from the clue
            // if you look for the max number of given values set the variable to the MIN of the variable OR the given MIN from the clue

            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    group1++;
                }
                if (num % 3 == 0)
                {
                    group2++;
                }
                if (num % 4 == 0)
                {
                    group3++;
                }             
            }           
            double percent1 = group1 * 1.0 / n * 100; // to take integers and divide to become double multiply by 1.0
            double percent2 = group2 * 1.0 / n * 100;
            double percent3 = group3 * 1.0 / n * 100;

            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
        }
    }
}
