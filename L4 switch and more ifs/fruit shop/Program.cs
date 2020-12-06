using System;

namespace fruit_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            плод banana apple orange grapefruit kiwi pineapple grapes
            //цена              2.50   1.20  0.85   1.45      2.70   5.50    3.85
            //Събота и неделя магазинът работи на по - високи цени:
            //            плод banana apple orange grapefruit kiwi pineapple grapes
            //цена              2.70    1.25 0.90   1.60      3.00  5.60       4.20
           
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.00;           

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit == "banana")
                    {
                        price = 2.5;
                    }
                    else if (fruit == "apple")
                    {
                        price = 1.20;
                    }
                    else if (fruit == "orange")
                    {
                        price = 0.85;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = 1.45;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = 2.70;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = 5.50;
                    }
                    else if (fruit == "grapes")
                    {
                        price = 3.85;
                    }
                   break;
                case "Saturday":
                case "Sunday":
                    if (fruit == "banana")
                    {
                        price = 2.70;
                    }
                    else if (fruit == "apple")
                    {
                        price = 1.25;
                    }
                    else if (fruit == "orange")
                    {
                        price = 0.90;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = 1.60;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = 3.00;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = 5.60;
                    }
                    else if (fruit == "grapes")
                    {
                        price = 4.20;
                    }
                  break;
            }

            double total = price * quantity;

            if (fruit != "apple" && fruit !="banana" && fruit != "kiwi" && fruit != "grapes" && fruit != "grapefruit" && fruit != "pineapple" && fruit != "orange")
            {
                Console.WriteLine("error");          
            }
            else if (day != "Monday" && day != "Tuesday" && day != "Wednesday" && day != "Thursday" && day != "Friday" && day != "Saturday" && day != "Sunday")
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
