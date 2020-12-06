using System;


namespace circle_perimeter_and_area
{
    class Program
    {
        static void Main(string[] args)
        {

           double r = double.Parse(Console.ReadLine());
            double area  = Math.PI * (r * r);
            Console.WriteLine($"{area:f2}");

            double perimeter = (2 * Math.PI) * r;
            Console.WriteLine($"{perimeter:f2}");
            Console.ReadLine();

        }
    }
}
