using System;
namespace odd_even_position
{
    class Program
    {
        static void Main(string[] args)
        {
            // if you look for the min number of given values set the variable to the MAX of the variable OR the given MAX from the clue
            // if you look for the max number of given values set the variable to the MIN of the variable OR the given MIN from the clue

            int n = int.Parse(Console.ReadLine());
            double sumOdd = 0;
            double sumEven = 0;
            double oddMin = 1000000000.0;
            double oddMax = -1000000000.0;
            double evenMin = 1000000000.0;
            double evenMax = -1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }

                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    sumOdd += num;

                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }                          
            }
             Console.WriteLine($"OddSum={sumOdd:f2},");

                if (oddMin == 1000000000.0)
                {
                    Console.WriteLine("OddMin=No,");
                }
                else
                {
                    Console.WriteLine($"OddMin={oddMin:f2},");
                }

                if (oddMax == -1000000000.0)
                {
                    Console.WriteLine("OddMax=No,");
                }
                else
                {
                    Console.WriteLine($"OddMax={oddMax:f2},");
                }
               
                Console.WriteLine($"EvenSum={sumEven:f2},");
                
                if (evenMin == 1000000000.0)
                {
                    Console.WriteLine("EvenMin=No,");
                }
                else
                {
                    Console.WriteLine($"EvenMin={evenMin:f2},");
                }

                if (evenMax == -1000000000.0)
                {
                    Console.WriteLine("EvenMax=No");
                }
                else
                {
                    Console.WriteLine($"EvenMax={evenMax:f2}");
                }

        }
    }
}
