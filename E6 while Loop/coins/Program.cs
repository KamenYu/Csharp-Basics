using System;
namespace coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal rest = decimal.Parse(Console.ReadLine());
            decimal restStotinki = rest * 100;
            int counter = 0;

            while (restStotinki != 0)
            {
                if (restStotinki >= 200)
                {
                    restStotinki -= 200;
                    counter++;
                }
                else if (restStotinki >= 100)
                {
                    restStotinki -= 100;
                    counter++;
                }
                else if (restStotinki >= 50)
                {
                    restStotinki -= 50;
                    counter++;
                }
                else if (restStotinki >= 20)
                {
                    restStotinki -= 20;
                    counter++;
                }
                else if (restStotinki >= 10)
                {
                    restStotinki -= 10;
                    counter++;
                }
                else if (restStotinki >= 5)
                {
                    restStotinki -= 5;
                    counter++;
                }
                else if (restStotinki >= 2)
                {
                    restStotinki -= 2;
                    counter++;
                }
                else if (restStotinki >= 1)
                {
                    restStotinki -= 1;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
