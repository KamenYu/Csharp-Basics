using System;

namespace аccount_balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int installment = int.Parse(Console.ReadLine());         // it is very important where the code is  
            double total = 0;
            int i = 0;

            while ( i < installment)
            {
                double increase = double.Parse(Console.ReadLine());              
                if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {total:f2}");
                    break;                   
                }
               
                Console.WriteLine($"Increase: {increase:f2}");
                i++;
                total += increase;

                if (i == installment)
                {
                    Console.WriteLine($"Total: {total:f2}");
                }
            }
        }
    }
}
