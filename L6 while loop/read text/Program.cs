using System;

namespace read_text
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "Stop")
                {
                    break;
                }
                counter += 1;
                
            }
            Console.WriteLine(counter);
        }
    }
}
