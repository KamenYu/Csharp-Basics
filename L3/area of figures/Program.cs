using System;


namespace area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            string a = Console.ReadLine();
            if (a == "square")
            {
                double sS = double.Parse(Console.ReadLine());
                double sA = sS * sS;
                Console.WriteLine($"{sA:f3}");
            }
            else if (a == "rectangle")
            {
                double rSA = double.Parse(Console.ReadLine());
                double rSB = double.Parse(Console.ReadLine());
                double rA = rSA * rSB;
                Console.WriteLine($"{rA:f3}");
            }
            else if (a == "circle")
            {
                double cR = double.Parse(Console.ReadLine());
                double cA = Math.PI * (cR * cR);
                Console.WriteLine($"{cA:f3}");
            }
            else if (a == "triangle")
            {
                double tS = double.Parse(Console.ReadLine());
                double tH = double.Parse(Console.ReadLine());
                double tA = tS * tH / 2;
                Console.WriteLine($"{tA:f3}");
            }
            goto Start;

        }
    }
}
