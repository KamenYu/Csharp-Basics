using System;
namespace sum_prime_non_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            // IN HERE -> how to find whether a number is PRIME or NONPrime
            string command = Console.ReadLine(); // number or text
            int sumPrime = 0;
            int sumNonPrime = 0;
            while (command != "stop")
            {
                int num = int.Parse(command);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }

                int delitel = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        delitel++;
                    }
                }
                if (delitel == 2)
                {
                    sumPrime += num;
                }
                else if (delitel > 2)
                {
                    sumNonPrime += num;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
