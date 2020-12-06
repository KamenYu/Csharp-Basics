using System;

namespace number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int integers = int.Parse(Console.ReadLine());

            int minInteger = int.MaxValue;
            int maxInteger = int.MinValue;

            for (int i = 1; i <= integers; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber > maxInteger)
                {
                    maxInteger = inputNumber;
                }
                if (inputNumber < minInteger)
                {
                    minInteger = inputNumber;
                }
            }
            Console.WriteLine($"Max number: {maxInteger}");
            Console.WriteLine($"Min number: {minInteger}");
        }
    }
}
