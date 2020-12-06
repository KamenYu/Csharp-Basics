using System;
namespace sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int comNum = 0; // the counter
            bool flag = false;

            for (int i = begin; i <= end; i++)
            {
                for (int j = begin; j <= end ; j++)
                {
                    comNum++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{comNum} ({i} + {j} = {magicNum})");
                        flag = true;
                        break;
                    }
                    if (i== end && j == end && i + j != magicNum)
                    {                      
                        Console.WriteLine($"{comNum} combinations - neither equals {magicNum}");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
        }
    }
}
