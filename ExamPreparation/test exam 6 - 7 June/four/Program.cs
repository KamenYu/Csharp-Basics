using System;
namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            int populationStart = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            int popN = populationStart; //
            int hatchedBees = 0;
            int deadBees = 0;
            int leftBees = 0;

            for (int i = 1; i <= years; i++)
            {               
                hatchedBees = popN / 10 * 2;
                popN += hatchedBees; 

                if (i % 5 == 0)
                {
                    leftBees = popN / 50 * 5;
                    popN -= leftBees;
                }               
                deadBees = popN / 20 * 2;
                popN -= deadBees;
            }
            Console.WriteLine($"Beehive population: {popN}");
        }
    }
}
