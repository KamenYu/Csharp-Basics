using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Покривките са правоъгълни, каретата са квадратни, броят им винаги е еднакъв.Покривката трябва да виси с !!30!! см от !!всеки
            //ръб!! на масата. Страната на каретата е половината от дължината на масите.Във всяка поръчка се включва
            //информация за броя и размерите на масите.
            //Напишете програма, която пресмята цената на поръчка в долари и в левове, като квадратен метър плат за
            //правоъгълна покривка струва 7 долара, а за каре – 9 долара.Курсът на долара е 1.85 лева.


            double t = double.Parse(Console.ReadLine()); // number of tables
            double ta = double.Parse(Console.ReadLine()); // table lenght for pokrivka in meters
            double tb = double.Parse(Console.ReadLine());  // table width for pokrivka in meters

            double areaP = t * (ta + (2 * 0.3)) * (tb + (2 * 0.3)); // area for pokrivki a*b + 30 cm into meters = 0.3, but 0.3 multiplied by 2
            // because every table has two rims
            double areaC = t * (ta / 2) * (ta / 2); // area of "kare" times the tables


            double aPC = (areaP * 7) + (areaC * 9); //price in USD
            double aPCL = aPC * 1.85; //price in bgn

            Console.WriteLine($"{aPC:f2} USD");
            Console.WriteLine($"{aPCL:f2} BGN");

            Console.ReadLine();

        }
    }
}
