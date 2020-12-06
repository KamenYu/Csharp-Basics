using System;
namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string typeOfHoliday = "";
            double amountSpent = 0.0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    typeOfHoliday = "Camp";
                    amountSpent = budget * 0.3;
                }
                else if (season == "winter")
                {
                    typeOfHoliday = "Hotel";
                    amountSpent = budget * 0.7;
                }
                destination = "Bulgaria";
            }
            else if (budget <=1000)
            {
                if (season == "summer")
                {
                    typeOfHoliday = "Camp";
                    amountSpent = budget * 0.4;
                }
                else if (season == "winter")
                {
                    typeOfHoliday = "Hotel";
                    amountSpent = budget * 0.8;
                }
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                typeOfHoliday = "Hotel";
                amountSpent = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHoliday} - {amountSpent:f2}");
            goto Start;
            //            Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи.
            //Ако е лято ще почива на къмпинг, а зимата в хотел. Ако е в Европа, независимо от сезона ще почива в хотел. 
            //Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета: 
            //•	При 100лв.или по-малко – някъде в България
            //o   Лято – 30 % от бюджета
            //o   Зима – 70 % от бюджета
            //•	При 1000лв.или по малко – някъде на Балканите
            //o   Лято – 40 % от бюджета
            //o   Зима – 80 % от бюджета
            //•	При повече от 1000лв. – някъде из Европа
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.

            //•	Втори ред –  Един от двата възможни сезона: „summer” или “winter”

            //На конзолата трябва да се отпечатат два реда.
            //•	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
            //•	Втори ред – “{Вид почивка} – {Похарчена сума}“
            //o Почивката може да е между „Camp” и „Hotel”
            //o Сумата трябва да е закръглена с точност до вторият знак след запетаята.
        }
    }
}
