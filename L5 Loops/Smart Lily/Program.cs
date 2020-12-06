using System;
namespace Smart_Lily
{
    class Program
    {
        static void Main(string[] args)
        {          
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            double evenGift = 0; 
            double moneyGift = 10;
            double toyGift = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    evenGift += moneyGift;
                    moneyGift += 10;
                    evenGift--;
                }
                else
                {
                    toyGift += 1;
                }
            }
            double sum = evenGift + toyGift * toysPrice;
            double diff = Math.Abs(sum - washingMachinePrice);
            if (sum >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
