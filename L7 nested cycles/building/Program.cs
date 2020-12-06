using System;
namespace building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floor; i >=1 ; i--) // with step i-- we make the output from the first floor to the max floor
            {                                // with i = 1; i <= floor; i++ we make the output from the last floor to the first
                for (int j = 0; j < rooms; j++)
                {
                    if (i == floor)
                    {
                        if (j == rooms - 1)
                        {
                            Console.WriteLine($"L{i}{j} ");
                        }
                        else
                        {
                            Console.Write($"L{i}{j} ");
                        }
                    }
                    else if (i % 2 == 0)
                    {
                        if (j == rooms - 1)
                        {
                            Console.WriteLine($"O{i}{j} ");
                        }
                        else
                        {
                            Console.Write($"O{i}{j} ");
                        }
                    }
                    else
                    {
                        if (j == rooms - 1)
                        {
                            Console.WriteLine($"A{i}{j} ");
                        }
                        else
                        {
                            Console.Write($"A{i}{j} ");
                        }
                    }
                }
            }
        }
    }
}
