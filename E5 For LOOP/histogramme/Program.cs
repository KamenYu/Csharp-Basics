using System;


namespace histogramme
{
    class Program
    {
        static void Main(string[] args)
        {
            // if you look for the min number of given values set the variable to the MAX of the variable OR the given MAX from the clue
            // if you look for the max number of given values set the variable to the MIN of the variable OR the given MIN from the clue

            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    group1++;
                }
                else if (num == 200 || num <= 399)
                {
                    group2++;
                }
                else if (num == 400 || num <= 599)
                {
                    group3++;
                }
                else if (num == 600 || num <= 799)
                {
                    group4++;
                }
                else if (num >= 800)
                {
                    group5++;
                }
            }
            double percent1 = group1 * 1.0 / n * 100; // to take integers and divide to become double multiply by 1.0
            double percent2 = group2 * 1.0 / n * 100;
            double percent3 = group3 * 1.0 / n * 100;
            double percent4 = group4 * 1.0 / n * 100;
            double percent5 = group5 * 1.0 / n * 100;

            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            Console.WriteLine($"{percent4:f2}%");
            Console.WriteLine($"{percent5:f2}%");
        }
    }
}
