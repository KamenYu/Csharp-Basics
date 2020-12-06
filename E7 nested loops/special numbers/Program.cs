using System;
namespace special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // IN HERE -> how to get the position of four digit numbers
            int n = int.Parse(Console.ReadLine());
            // generate special numbers from 1111 to 9999

            for (int i = 1111; i <= 9999; i++)
            {
                int thousands = i / 1000;
                int hundreds = (i / 100) % 10;
                int tens = (i / 10) % 10;
                int units = i % 10;

                bool check1 = thousands!= 0 && n % thousands == 0;
                bool check2 = hundreds != 0 && n % hundreds == 0;
                bool check3 = tens != 0 && n % tens == 0;
                bool check4 = units != 0 && n % units == 0;

                if (check1 && check2 && check3 && check4) //(n % thousands == 0 && n % hundreds == 0 && n % tens == 0 && n % units == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
