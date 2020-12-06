using System;
namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());           
            
            int area = lenght * width;

            while (area > 0)
            {
                string cake = Console.ReadLine();
                if (cake == "STOP")
                {
                    Console.WriteLine($"{area} pieces are left.");
                    break;
                }
                int cakePieces = int.Parse(cake);
                area -= cakePieces;                                                   
            }
            if (area < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(area)} pieces more.");
            }
        }
    }
}
