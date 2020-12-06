using System;
namespace left_aand_right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете 2 * n - на брой цели числа, подадени от потребителя, 
            //и проверява дали сумата на първите n числа(лява сума) е равна на сумата на вторите n числа(дясна сума). 
            //При равенство печата " Yes, sum = " + сумата; иначе печата " No, diff = " + разликата.
            //Разликата се изчислява като положително число(по абсолютна стойност).

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                int numToBeAdded1 = int.Parse(Console.ReadLine());
                sum += numToBeAdded1;             
            }
            for (int l = 1; l <= n; l++)
            {
                int numToBeAdded2 = int.Parse(Console.ReadLine());
                sum2 += numToBeAdded2;
            }

            int diff = Math.Abs(sum - sum2);

            if (sum == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
