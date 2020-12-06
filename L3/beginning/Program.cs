using System;


namespace beginning
{
    class Program
    {
        static void Main(string[] args)
        {
           // Start:
            double grade = double.Parse(Console.ReadLine());           
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");

            }
            //goto Start;
        }
    }
}
