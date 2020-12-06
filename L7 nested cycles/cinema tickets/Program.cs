using System;
namespace cinema_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double sum = 0;
            double kidsCounter = 0;
            double studentCounter = 0;
            double standartCounter = 0;

            while (movieName != "Finish")
            {
                double seats = double.Parse(Console.ReadLine());
                double counter = 0;
                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    switch (ticketType)
                    {
                        case "kid":
                            kidsCounter++;
                            break;
                        case "standard":
                            standartCounter++;
                            break;
                        case "student":
                            studentCounter++;
                            break;
                    }
                    counter++;
                    if (counter == seats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                sum += counter;

                double occupancy = counter / seats * 100;
                Console.WriteLine($"{movieName} - {occupancy:f2}% full.");

                movieName = Console.ReadLine();
            }
            double studentTicketsPercent = studentCounter / sum * 100;
            double standardTicketsPercent = standartCounter / sum * 100;
            double kidTicketsPercent = kidsCounter / sum * 100;

            Console.WriteLine($"Total tickets: {sum}");
            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");
        }
    }
}
