using System;
namespace graduation_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // use continue; when needed inside an if 
            string name = Console.ReadLine();
            double a;
            int i = 1;
            double sum = 0;

            while (i <= 12)
            {
                a = double.Parse(Console.ReadLine());
                if (a >= 4)
                {
                    sum += a;
                    i++;
                }               
            }

            double average = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
        }
    }
}
