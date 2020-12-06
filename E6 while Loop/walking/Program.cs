using System;
namespace walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;

            while (steps < 10000)
            {
                string walkingSteps = Console.ReadLine();

                if (walkingSteps == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    steps += stepsToHome;                   
                    break;
                }
                else
                {
                    int walkedSteps = int.Parse(walkingSteps);
                    steps += walkedSteps;
                }
            }
            if (steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
        }
    }
}
