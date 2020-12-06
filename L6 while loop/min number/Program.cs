using System;
namespace min_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numMin = int.MaxValue;
            int i = 0;

            while (i < n)
            {
                int num = int.Parse(Console.ReadLine());
                i++;
                if (num < numMin)
                {
                    numMin = num;
                }

            }
            Console.WriteLine(numMin);
        }
    }
}
