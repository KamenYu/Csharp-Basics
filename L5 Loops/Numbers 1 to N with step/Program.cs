using System;
namespace Numbers_1_to_N_with_step
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step by 3
            int num = int.Parse(Console.ReadLine());
            for (int N = 1; N <= num; N += 3)
            {
                Console.WriteLine(N);
            }


        }
    }
}
