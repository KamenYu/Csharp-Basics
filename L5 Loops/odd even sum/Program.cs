using System;
namespace odd_even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции.
            //При равенство да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата;
            //иначе да се отпечата "No" и на нов ред "Diff = " + разликата.  Math.Abs
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum2 = 0;

            for (int i = 1; i <= n; i++)
            {
                int numToBeAdded1 = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum += numToBeAdded1;
                }
                else
                {
                    sum2 += numToBeAdded1;
                }
            }

            int diff = Math.Abs(sum - sum2);
            if (sum == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
