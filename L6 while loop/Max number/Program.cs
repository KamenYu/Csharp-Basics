using System;

namespace Max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numMax = int.MinValue;
            int i = 0;

            while (i < n)
            {
                int num = int.Parse(Console.ReadLine());
                i++;
                if (num > numMax)
                {
                    numMax = num;
                }

            }
            Console.WriteLine(numMax);
        }
    }
}
