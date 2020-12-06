using System;
namespace sum_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int integers = int.Parse(Console.ReadLine());
           
            int sum = 0;

            for (int i = 1; i <= integers; i++ )
            {
                int numbersToBeSummed = int.Parse(Console.ReadLine());
                sum += numbersToBeSummed;
            }
            Console.WriteLine(sum);
        }
    }
}
