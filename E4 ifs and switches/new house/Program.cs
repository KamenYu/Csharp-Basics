using System;
namespace new_house
{
    class Program
    {
        static void Main(string[] args)
        {
        //            цвете  Роза  Далия  Лале    Нарцис  Гладиола
        //Цена на брой в лева 5   3.80    2.80    3       2.50

        //•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
        //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
        //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
        //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
        //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %               

        //•	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
        //Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."
       // Start:
            string flowers = Console.ReadLine();
            int amountOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;
           
            if (flowers == "Roses")
            {
                if (amountOfFlowers > 80)
                {
                    price = (amountOfFlowers * 5) - ((amountOfFlowers * 5) * 0.1);
                }
                else
                {
                    price = amountOfFlowers * 5;
                }
            }
            else if (flowers == "Dahlias")
            {
                if (amountOfFlowers > 90)
                {
                    price = (amountOfFlowers * 3.8) - ((amountOfFlowers * 3.8) * 0.15);
                }
                else
                {
                    price = amountOfFlowers * 3.8;
                }
            }
            else if (flowers == "Tulips")
            {
                if (amountOfFlowers > 80)
                {
                    price = (amountOfFlowers * 2.8) - ((amountOfFlowers * 2.8) * 0.15);
                }
                else
                {
                    price = amountOfFlowers * 2.8;
                }
            }
            else if (flowers == "Narcissus")
            {
                if (amountOfFlowers < 120)
                {
                    price = (amountOfFlowers * 3) + ((amountOfFlowers * 3) * 0.15);
                }
                else
                {
                    price = amountOfFlowers * 3;
                }
            }
            else if (flowers == "Gladiolus")
            {
                if (amountOfFlowers < 80)
                {
                    price = (amountOfFlowers * 2.5) + ((amountOfFlowers * 2.5) * 0.2);
                }
                else
                {
                    price = amountOfFlowers * 2.5;
                }
            }
            double leftMoney = Math.Abs(budget - price);
            if (price <= budget) // here was the mistake, it was without the =
            {              
                Console.WriteLine($"Hey, you have a great garden with {amountOfFlowers} {flowers} and {leftMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {leftMoney:f2} leva more.");
            }
            //goto Start;
        }
    }
}
