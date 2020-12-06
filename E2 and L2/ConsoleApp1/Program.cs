using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            

            //making projects
            //The architect George will need 12 hours to complete 4 project/s.

            string aN = Console.ReadLine();
            double proj = double.Parse(Console.ReadLine());
            double pHours = proj * 3;


            Console.WriteLine($"The architect {aN} will need {pHours} hours to complete {proj} project/s.");
            Console.ReadLine();


            // converter in inches
            double N = double.Parse(Console.ReadLine());
            double inches = N * 2.54;
            Console.WriteLine(inches);
            Console.ReadLine();


            //area

            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            Console.WriteLine(area);
            Console.ReadLine();

            //Concatenation
            //"You are <firstName> <lastName>, a <age>-years old person from <town>."


            string fN = Console.ReadLine();
            string lN = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string T = Console.ReadLine();

            // the dollar sign makes interpolation

            Console.WriteLine($"You are {fN} {lN}, a {age}-years old person from {T}.");
            // Console.ReadLine();


            // ctrl + K + C comment
            //ctrl + K + U uncomment


            // greeting
          string name = Console.ReadLine();
          Console.WriteLine("Hello, " + name + "!");
          Console.ReadLine();
        }
    }
}
