using System;
namespace operations_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double sum = 0.0;
            string oddOrEven = "";

            if (symbol == "+")
            {
                sum = N1 + N2;
            }
            else if (symbol == "-")
            {
                sum = N1 - N2;
            }
            else if (symbol == "*")
            {
                sum = N1 * N2;
            }

            if (sum % 2 == 0)
            {
                oddOrEven = "even";
            }
            else
            {
                oddOrEven = "odd";
            }

            if (symbol == "/")
            {
                sum = N1 / N2;
            }
            else if (symbol == "%")
            {
                sum = N1 % N2;
            }

            switch (symbol)
            {
                case "+":
                case "-":
                case "*":
                    Console.WriteLine($"{N1} {symbol} {N2} = {sum} - {oddOrEven}");
                    break;
                case "/":
                    if (N2 > 0)
                    {
                        Console.WriteLine($"{N1} / {N2} = {sum:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
                case "%":
                    if (N2 > 0)
                    {
                        Console.WriteLine($"{N1} % {N2} = {sum}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }                 
                    break;
                default:
                    break;
            }
        }
    }
}
