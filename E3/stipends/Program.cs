using System;
namespace stipends
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohodLv = double.Parse(Console.ReadLine());
            double avGrade = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            double socialStipend = Math.Floor(0.35 * minWage);
            double excellentStipend = Math.Floor(avGrade * 25);
           
            if (avGrade < 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (dohodLv >= minWage)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (dohodLv < minWage)
            {
                if (avGrade > 4.5 && avGrade < 5.5)
                {
                    Console.WriteLine($"You get a Social scholarship {socialStipend} BGN");
                }
                else if (avGrade >= 5.5 && socialStipend > excellentStipend)
                {
                    Console.WriteLine($"You get a Social scholarship {socialStipend} BGN");
                }
                else if (socialStipend == excellentStipend)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentStipend} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentStipend} BGN");
                }
            }
        }
    }
}
