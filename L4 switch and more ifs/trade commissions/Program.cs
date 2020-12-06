using System;
namespace trade_commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double percentSales = 0.00;

           if (sales <= 500 && sales >=0)
           {
               if (city == "Sofia")
               {
                    percentSales = 0.05;
               }
               else if (city == "Varna")
               {
                    percentSales = 0.045;
               }
               else if (city == "Plovdiv")
               {
                    percentSales = 0.055;
               }
           }
           else if (sales > 500 && sales <=1000)
           {
                if (city == "Sofia")
                {
                    percentSales = 0.07;
                }
                else if (city == "Varna")
                {
                    percentSales = 0.075;
                }
                else if (city == "Plovdiv")
                {
                    percentSales = 0.08;
                }
           }
           else if (sales > 1000 && sales <=10000)
           {
                if (city == "Sofia")
                {
                    percentSales = 0.08;
                }
                else if (city == "Varna")
                {
                    percentSales = 0.1;
                }
                else if (city == "Plovdiv")
                {
                    percentSales = 0.12;
                }
           }
           else if (sales  > 10000)
            {
                if (city == "Sofia")
                {
                    percentSales = 0.12;
                }
                else if (city == "Varna")
                {
                    percentSales = 0.13;
                }
                else if (city == "Plovdiv")
                {
                    percentSales = 0.145;
                }
           }
            double total = sales * percentSales; 

            if (sales < 0)
            {
                Console.WriteLine("error");
            }
            else if (city != "Sofia" && city != "Varna" && city != "Plovdiv")
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{total:f2}");
            }
        }
    }
}
