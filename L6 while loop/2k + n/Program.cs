using System;

namespace _2k___n
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1, (1 * 2) + 1 = 3, (3 * 2) + 1 = 7, (7 * 2) + 1 = 15 
            int n = int.Parse(Console.ReadLine());  // read a number
            int k = 1;                              // set the beginning to be 1
            while (k <= n)                          // while k <= n do the loop where we will always change k || until k > n, then end the Loop
            {
                Console.WriteLine(k);               // type k
                k = 2 * k + 1;                      // change k according to the recipe
            }                                       // aaaand LOOP ||

        }
    }
}
