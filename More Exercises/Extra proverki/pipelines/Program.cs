using System;


namespace pipelines
{
    class Program
    {
        static void Main(string[] args)
        {
            int obem = int.Parse(Console.ReadLine());
            int obemP1 = int.Parse(Console.ReadLine());
            int obemP2 = int.Parse(Console.ReadLine());
            double hoursMissing = double.Parse(Console.ReadLine());

            double debitP1 = obemP1 * hoursMissing;
            double debitP2 = obemP2 * hoursMissing;

            double allDebit = debitP1 + debitP2;

            double percentage1 = (debitP1 / allDebit) * 100;
            double percentage2 = (debitP2 / allDebit) * 100;

            double poolPercentage = (allDebit / obem) * 100;

            if (allDebit > obem)
            {
                double overflow = allDebit - obem;
                Console.WriteLine($"For {hoursMissing} hours the pool overflows with {overflow:f2} liters.");
            }
            else
            {
                Console.WriteLine($"The pool is {poolPercentage:f2} full.Pipe 1: {percentage1:f2}%.Pipe 2: {percentage2:f2}%.");                   
            }
        }
    }
}
