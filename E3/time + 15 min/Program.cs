using System;


namespace time___15_min
{
    class Program
    {
        static void Main(string[] args)
        {
            // what is the time after 15 min :(
            // 1 and 46 -> 2:01
            // 00 and 59 -> 00:14
           Start:
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int timeLapsed = min + 15;



            goto Start;





        }
    }
}
