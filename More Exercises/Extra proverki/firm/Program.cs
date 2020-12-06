using System;

namespace firm
{
    class Program
    {
        static void Main(string[] args)
        {
            //През 10 % от дните служителите са на обучение и не могат да работят по проекта. 
            //Един нормален работен ден във фирмата е 8 часа. Всеки служител може да работи по проекта в извънработно време по 2 часа на ден.
            //Math.Floor
            //Напишете програма, която изчислява дали фирмата може да завърши проекта навреме и колко часа не достигат или остават.
            //•	На първия ред са необходимите часовете – цяло число в интервала[0... 200 000]
            int hoursNeeded = int.Parse(Console.ReadLine());
            //•	На втория ред са дните, с които фирмата разполага – цяло число в интервала[0... 20 000]
            int daysGot = int.Parse(Console.ReadLine());
            //•	На третия ред е броят на служителите, работещи извънредно – цяло число в интервала[0... 200]
            int extraWorkingWorkers = int.Parse(Console.ReadLine());
            double education = daysGot - daysGot * 0.1;

            double totalHours = education * 8;
            double extraHours = extraWorkingWorkers * (2 * daysGot);
            double allHours = Math.Floor(extraHours + totalHours);
            double hoursFinal = Math.Abs(hoursNeeded - allHours);

            if (hoursNeeded <= allHours)
            {
                Console.WriteLine($"Yes!{Math.Floor(hoursFinal)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Floor(hoursFinal)} hours needed.");
            }
        }
    }
}
