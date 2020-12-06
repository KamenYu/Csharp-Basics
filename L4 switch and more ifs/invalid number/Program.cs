using System;

namespace invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Дадено число е валидно, ако е в диапазона[100…200] или е 0.Да се напише програма, която чете цяло
            //число, въведено от потребителя, и печата & quot; invalid & quot; ако въведеното число не е валидно.
           // Start:
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("");
            }
            else if (num < 100)
            {
                Console.WriteLine("invalid");
            }
            else if (num > 200)
            {
                Console.WriteLine("invalid");
            }
            
          //  goto Start;


        }
    }
}
