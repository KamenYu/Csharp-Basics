using System;
namespace character_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int letters = 0; letters < text.Length; letters ++)
            {
                char symbol = text[letters];
                Console.WriteLine(symbol);
            }
        }
    }
}
