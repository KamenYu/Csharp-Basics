using System;

namespace numbers_ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // if you look for the min number of given values set the variable to the MAX of the variable OR the given MAX from the clue
            // if you look for the max number of given values set the variable to the MIN of the variable OR the given MIN from the clue

            // numbers ending in 7 until 1000
            for (int num = 7; num <= 997; num += 10)
            {
                Console.WriteLine(num);
            }
            // OR

            //for (int numBySeven = 1; numBySeven <= 1000; numBySeven++)
            //{
            //    Console.WriteLine(numBySeven);
            //}           
        }
    }
}
