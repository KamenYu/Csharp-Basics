using System;
namespace five
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());    // == beesHealth
            int healthBear = int.Parse(Console.ReadLine());
            int attackBear = int.Parse(Console.ReadLine());

            while (healthBear > 0)
            {
                bees -= attackBear;
                int beesAttack = bees * 5;
                healthBear -= beesAttack;
                if (bees < 100)
                {
                    if (bees <= 0)
                    {
                        bees = 0;
                        Console.WriteLine($"The bear stole the honey! Bees left {bees}.");
                        break;
                    }
                    Console.WriteLine($"The bear stole the honey! Bees left {bees}.");
                    break;
                }
            }
            if (healthBear <= 0)
            {

                Console.WriteLine($"Beehive won! Bees left {bees}.");
            }

        }
    }
}
