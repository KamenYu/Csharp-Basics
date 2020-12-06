using System;
namespace the_old_library
{
    class Program
    {
        static void Main(string[] args)
        {
            // ctrl+r+r to rename the name of a variable everywhere
            string book = Console.ReadLine();            
            int totalBooks = int.Parse(Console.ReadLine());
            int counter = 0;           

            while (totalBooks > 0)
            {
                string nextBook = Console.ReadLine();  
                if (nextBook == book)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                else
                {
                    counter++;
                }
                totalBooks--;
            }
            if (totalBooks <= 0)
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
