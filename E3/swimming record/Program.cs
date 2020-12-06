using System;

namespace swimming_record
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double worldRecordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

            double extraSeconds = Math.Floor(distanceInMeters / 15);
            double addedSeconds = extraSeconds * 12.5;

            double swimming = (distanceInMeters * timeInSecondsForOneMeter) + addedSeconds;
            double diff = swimming- worldRecordInSeconds ;

            if (swimming < worldRecordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swimming:f2} seconds.");
                
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {diff:f2} seconds slower.");
            }

        }
    }
}
