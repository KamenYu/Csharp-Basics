using System;


namespace training_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()); // teaching hall  lenght in m
            double h = double.Parse(Console.ReadLine()); // teaching hall width in m 
            double wPa = 1.2; // in m
            double wPb = 0.7; // in m
            double a = Math.Floor( w / wPa);
            double b = Math.Floor((h -1)/ wPb );
            double c = (a * b) - 3;
       
            Console.WriteLine(c);

            Console.ReadLine();

           

        }
    }
}
