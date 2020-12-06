using System;
namespace train_the_trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double totalSum = 0;
            int counter = 0;
            while (presentationName != "Finish")
            {
                double sum = 0;
                for (int i = 1; i <= jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    totalSum += grade;
                    counter++;
                }
                double average = sum / jury;

                Console.WriteLine($"{presentationName} - {average:f2}.");
                presentationName = Console.ReadLine();
            }
            double totalAverage = totalSum / counter;
            Console.WriteLine($"Student's final assessment is {totalAverage:f2}.");
        }
    }
}
