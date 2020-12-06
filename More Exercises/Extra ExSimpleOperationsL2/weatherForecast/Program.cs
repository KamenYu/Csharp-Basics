using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
          // Start: to  begin a cycle for the program to check many possibilities
            string weather = Console.ReadLine(); ;
            if (weather == "sunny")
            {
                Console.WriteLine("It's warm outside!");

            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
          //  goto Start;
            Console.ReadLine();



        }
    }
}
