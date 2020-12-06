using System;

namespace harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //От лозе с площ X квадратни метри се заделя 40 % от реколтата за производство на вино.
            //От 1 кв.м лозе се изкарват Y килограма грозде.За 1 литър вино са нужни 2,5 кг.грозде.Желаното количество вино за продан е Z литра.
            //Напишете програма, която пресмята колко вино може да се произведе и дали това количество е достатъчно.
            //Ако е достатъчно, остатъкът се разделя по равно между работниците на лозето.
           
            double X = double.Parse(Console.ReadLine());
            //•	1ви ред: X кв.м е лозето – цяло число в интервала[10 … 5000]
            double Y = double.Parse(Console.ReadLine());
            //•	2ри ред: Y грозде за един кв.м – реално число в интервала[0.00 … 10.00]
            double Z = double.Parse(Console.ReadLine());
            //•	3ти ред: Z нужни литри вино – цяло число в интервала[10 … 600]
            int workers = int.Parse(Console.ReadLine());
            //•	4ти ред: брой работници – цяло число в интервала[1 … 20]

            double totalGrapes = X * Y;
            double totalWine = 0.4 * totalGrapes / 2.5;
            double leftWine = 0;

            if (totalWine < Z)
            {
                leftWine = Z - totalWine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(leftWine)} liters wine needed.");
            }
            else 
            {
                leftWine = totalWine - Z;
                double winePerWorker = leftWine / workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
                Console.WriteLine($" {Math.Ceiling(leftWine)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");
            }
                   
            //•	Ако произведеното вино е по - малко от нужното:
            //o   “It will be a tough winter!More {Math.Fllor(недостигащо вино)} liters wine needed.”           
            //•	Ако произведеното вино е повече от нужното:
            //            o   “Good harvest this year!Total wine: {Math.Floor(общо вино)} liters.”           
            //o               “{Math.Ceiling(Оставащо вино)} liters left -> {Math.Ceiling(вино за 1 работник)} liters per person.”           
        }
    }
}
