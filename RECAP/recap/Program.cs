using System;


namespace recap
{
    class Program
    {
        static void Main(string[] args)
        {
            // NAKOV

            // shablon

            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1}!", name, 18); // name is zero position, 18 is first position

            // dateTime - you can add or deduct dates

            var d1 = new DateTime(1999, 2, 15);
            var d2 = new DateTime(1990, 7, 18);
           
            Console.WriteLine(d1 - d2);


        }
    }
}
