using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fish_market
{
    class Program
    {
        static void Main(string[] args)
        {

            double scumriaPPerKg = double.Parse(Console.ReadLine()); //scumria price per kg
            double cacaPPerKg = double.Parse(Console.ReadLine()); // caca price per kg
            double palamudW = double.Parse(Console.ReadLine()); // palamud and the rest weight in kg
            double safidW = double.Parse(Console.ReadLine()); 
            double midi = double.Parse(Console.ReadLine());

            double palP = palamudW * (0.6*scumriaPPerKg + scumriaPPerKg);// palamud price
            double safP = safidW * (0.8*cacaPPerKg + cacaPPerKg);
            double midiP = midi * 7.5;
            double bill = palP + safP + midiP;

       

            Console.WriteLine($"{bill:f2}");
            Console.ReadLine();


        }
    }
}
