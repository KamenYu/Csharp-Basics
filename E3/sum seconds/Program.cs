using System;


namespace sum_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
           // Start:
            int timeA = int.Parse(Console.ReadLine());
            int timeB = int.Parse(Console.ReadLine());
            int timeC = int.Parse(Console.ReadLine());

            int sum = timeA + timeB + timeC;
            int min = sum / 60;
            int seconds = sum % 60;

            if (seconds <= 9)
            {
                Console.WriteLine(min + ":0" + seconds);
            }
            else if (seconds <=59 )
            {
                Console.WriteLine(min + ":" + seconds);
            }
            else if (seconds == 0)
            {
                Console.WriteLine(min + ":" + 00);
            }
          //  goto Start;

        }
    }
}
