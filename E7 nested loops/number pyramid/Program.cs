using System;

namespace number_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isBigger = false;
            int current = 1;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int col = 1; col <= rows; col++) // columns <= ROWS, to make the program to get to the next row
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
