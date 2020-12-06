using System;


namespace graduation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // use continue; when needed inside an if 
            string name = Console.ReadLine();
            double a;
            int i = 1;
            int grade = 1;
            double sum = 0;

            while (i <= 12)
            {
                a = double.Parse(Console.ReadLine());
                
                if (a >= 4)
                {
                    sum += a;
                    i++;
                    grade++;
                }
                if (a == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    break;
                }
            }
            if (i == 13)
            {
                double average = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
           
           
        }
    }
}
