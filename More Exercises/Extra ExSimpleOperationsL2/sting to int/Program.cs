using System;


namespace sting_to_int
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "4.589";
            double num1 = double.Parse(num);
            Console.WriteLine($"{num1:f2}");

            string num2 = "5";
            int num3 = Int32.Parse(num2);
            Console.WriteLine(num3);
            Console.ReadLine();

        }
    }
}
