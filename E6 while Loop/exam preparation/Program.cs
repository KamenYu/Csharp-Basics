using System;
namespace exam_preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int notSatisfactoryGrades = int.Parse(Console.ReadLine());
            int failedTests = 0;
            double testGradeSum = 0;
            double average = 0;
            string lastProblem = "";

            while (notSatisfactoryGrades > failedTests)
            {
                string testName = Console.ReadLine();
                
                if ("Enough" == testName)
                {
                    Console.WriteLine($"Average score: {testGradeSum / average:f2}");
                    Console.WriteLine($"Number of problems: {average}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                int testGrade = int.Parse(Console.ReadLine());
                if (testGrade <=4)
                {
                    failedTests++;
                }               
                testGradeSum += testGrade;
                average++;
                lastProblem = testName;
            }
            if (notSatisfactoryGrades <= failedTests)
            {
                Console.WriteLine($"You need a break, {notSatisfactoryGrades} poor grades.");
            }           
        }
    }
}
