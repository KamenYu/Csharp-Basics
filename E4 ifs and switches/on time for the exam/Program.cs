using System;

namespace on_time_for_the_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMunite = int.Parse(Console.ReadLine());
            // make everything in either minutes or either hours, but minutes are easier

            int inMinutesExam = examHour * 60 + examMinute;
            int inMinutesArrival = arrivingHour * 60 + arrivingMunite;

            if (inMinutesArrival > inMinutesExam) // late
            {
                Console.WriteLine("Late");
                int late = inMinutesArrival - inMinutesExam;

                if (late < 60)
                {
                    Console.WriteLine($"{late} minutes after the start");
                }
                else
                {
                    int lateHours = late / 60;
                    int lateMinutes = late % 60;
                    Console.WriteLine($"{lateHours}:{lateMinutes:d2} hours after the start");
                }
            }
            else if (inMinutesArrival == inMinutesExam || inMinutesExam - inMinutesArrival <= 30) // on time
            {
                Console.WriteLine("On time");

                if (inMinutesExam - inMinutesArrival <= 30 && examMinute != arrivingMunite)
                {
                    Console.WriteLine($"{inMinutesExam - inMinutesArrival} minutes before the start");
                }
            }
            else if (inMinutesExam - inMinutesArrival > 30) // early
            {
                int early = inMinutesExam - inMinutesArrival;
                Console.WriteLine("Early");
                if (early < 60)
                {
                    Console.WriteLine($"{early} minutes before the start"); // coming early
                }
                else // ealier than one hour
                {
                    int earlyInMin = early % 60;
                    int earlyInHours = early / 60;
                    Console.WriteLine($"{earlyInHours}:{earlyInMin:d2} hours before the start");
                }
            }
        }
    }
}
