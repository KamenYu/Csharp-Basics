using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_figures_how_is_supposed_to_be
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double area = 0;

            if (a == "square")
            {
                double sS = double.Parse(Console.ReadLine());
                area = sS * sS;
            }
            else if (a == "rectangle")
            {
                double rSA = double.Parse(Console.ReadLine());
                double rSB = double.Parse(Console.ReadLine());
                area = rSA * rSB;
            }
            else if (a == "circle")
            {
                double cR = double.Parse(Console.ReadLine());
                area = Math.PI * (cR * cR);
            }
            else if (a == "triangle")
            {
                double tS = double.Parse(Console.ReadLine());
                double tH = double.Parse(Console.ReadLine());
                area = tS * tH / 2;
                
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
