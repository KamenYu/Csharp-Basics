using System;


namespace bigger_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            goto Start;

        }
    }
}
