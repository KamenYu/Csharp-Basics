using System;
namespace equal_sums__even_odd_position
{
    class Program
    {
        static void Main(string[] args)
        {
            // 100000 to 300000
            // the sum of of odd and even positions to be equal
            // 123456 -> 1+3+5=9; 2+4+6=12; 9 != 12 -> no output

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if(oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
