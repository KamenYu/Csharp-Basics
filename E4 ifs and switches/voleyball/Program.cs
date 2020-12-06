using System;

namespace voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Първият ред съдържа думата "leap"(високосна година) или "normal"(невисокосна).
            string year = Console.ReadLine();
            //•	Вторият ред съдържа цялото число p – брой празници в годината(които не са събота и неделя).
            double holidays = double.Parse(Console.ReadLine());
            //•	Третият ред съдържа цялото число h – брой уикенди, в които Влади си пътува до родния град.
            double weekendsInHometown = double.Parse(Console.ReadLine());

            //Влади играе в София всяка събота, когато не е на работа и не си пътува до родния град, както и в 2 / 3 от празничните дни.
            //Той пътува до родния си град h пъти в годината, където играе волейбол със старите си приятели в неделя. 
            //Влади не е на работа 3 / 4 от уикендите, в които е в София. 
            //Отделно, през високосните години Влади играе с 15 % повече волейбол от нормалното.
            //Приемаме, че годината има точно 48 уикенда, подходящи за волейбол.
            //Напишете програма, която изчислява колко пъти Влади е играл волейбол през годината. Math.Floor

            double allWeekends = 48;
            double weekendsInSofia = (allWeekends - weekendsInHometown) * 0.75;
            double holidayVolleyball = holidays * 2 / 3;
            
            double freeWeekends = weekendsInSofia + holidayVolleyball + weekendsInHometown;
            double yearVolleyball = 0;

            if (year == "leap")
            {
                yearVolleyball = freeWeekends * 0.15 + freeWeekends;
            }
            else if (year == "normal")
            {
                yearVolleyball = freeWeekends;
            }
            Console.WriteLine($"{Math.Floor(yearVolleyball)}");
        }
    }
}
