using System;


namespace time___15_min_a
{
    class Program
    {
        static void Main(string[] args)
        {
           // Start:
            int printedHours = int.Parse(Console.ReadLine());
            int printedMin = int.Parse(Console.ReadLine());
            int  hours = ((printedHours * 60) + printedMin + 15) / 60;
            int min = ((printedHours * 60) + printedMin + 15) % 60;

            if (hours == 24 )
            {
                hours = 0;
            }
            if (min < 0)
            {
                Console.WriteLine(hours + ":0" + min);
            }
            // Console.WriteLine($"{hours}:{min}");
            Console.WriteLine("{0}:{1:00}", hours, min);
          //  goto Start;
           

           // Console.WriteLine("{0}:{1:00}", hours, min);


        }
    }
}
