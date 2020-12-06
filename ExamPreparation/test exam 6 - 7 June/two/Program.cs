using System;
namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            // 90 from 100
            int brain = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();    // ["female", "male"]

            //     роля       интелект    сила             пол

            //Queen Bee        >= 80       >= 80        female
            //Repairing Bee    >= 80       Any           Any
            //Cleaning Bee     >= 60       Any           Any
            //Drone Bee        Any         >= 80         male
            //Guard Bee        Any         >= 60         Any
            //Worker Bee       Any         Any           Any

            if (brain >= 80 && power >= 80 && gender == "female")
            {
                Console.WriteLine("Queen Bee");
            }
            else if (brain >= 80)
            {
                Console.WriteLine("Repairing Bee");
            }
            else if (brain >= 60)
            {
                Console.WriteLine("Cleaning Bee");
            }
            else if (power >= 80)
            {
                if (gender == "male")
                {
                    Console.WriteLine("Drone Bee");
                }
            }
            else if (power >= 60)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");
            }
        }
    }
}
