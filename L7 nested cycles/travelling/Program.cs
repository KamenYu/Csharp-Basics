using System;
namespace travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savedMoney = double.Parse(Console.ReadLine());
                double total = 0;

                while (total < budget)
                {
                    total += savedMoney;                    
                    if (total >= budget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                    savedMoney = double.Parse(Console.ReadLine());
                }
                destination = Console.ReadLine();
            }
        }
    }
}
