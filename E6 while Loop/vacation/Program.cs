using System;
namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int counter = 0;
            int countTotal = 0;

            while (availableMoney < moneyForVacation)
            {
                string action = Console.ReadLine();
                countTotal ++;
                double actionMoney = double.Parse(Console.ReadLine());

                if (action == "save")
                {
                    availableMoney += actionMoney;
                    counter = 0;
                }
                else if (action == "spend")
                {
                    counter++;
                    availableMoney -= actionMoney;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }

                if (counter == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine(countTotal);
                    break;
                }
            }
            if (availableMoney >= moneyForVacation)
            {
                Console.WriteLine($"You saved the money for {countTotal} days.");
            }
        }
    }
}
