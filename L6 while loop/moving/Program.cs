using System;

namespace moving
{
    class Program
    {
        static void Main(string[] args)
        {      
            int widht = int.Parse(Console.ReadLine());          
            int lenght = int.Parse(Console.ReadLine());         
            int height = int.Parse(Console.ReadLine());

            int volume = widht * lenght * height;
            string input = Console.ReadLine();
            int sum = 0;

            while (input != "Done")
            {
                sum += int.Parse(input);
                if (sum > volume)
                {
                    Console.WriteLine($"No more free space! You need {sum - volume} Cubic meters more.");
                    break;
                }               
                input = Console.ReadLine();               
            }
            if (input == "Done")
            {
                Console.WriteLine($"{volume - sum} Cubic meters left.");
            }

                     
        }
    }
}
