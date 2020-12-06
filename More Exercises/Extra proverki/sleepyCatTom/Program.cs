using System;

namespace sleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());
           
            int tomNorm = 30000; // min per year
            int year = 365;
            int diff = year - freeDays;
            int realTime = (freeDays * 127) + (diff * 63);
            int diff2 = tomNorm - realTime;
            int diffH = Math.Abs(diff2 / 60);
            int diffM = Math.Abs(diff2 % 60);

            if (realTime > tomNorm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{diffH} hours and {diffM} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{diffH} hours and {diffM} minutes less for play");
            }

        }
    }
}
