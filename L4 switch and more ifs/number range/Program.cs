using System;

namespace number_range
{
    class Program
    {
        static void Main(string[] args)
        {  
            double num = double.Parse(Console.ReadLine());
           
            if (num >=-100 && num <=100)
            {
                if (num == 0)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }
            else if (num > 100)
            {
                Console.WriteLine("No");
            }
            else if (num < -100)
            {
                Console.WriteLine("No");
            }


        }
    }
}
