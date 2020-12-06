using System;


namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            // if you look for the min number of given values set the variable to the MAX of the variable OR the given MAX from the clue
            // if you look for the max number of given values set the variable to the MIN of the variable OR the given MIN from the clue

            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());       

            for (int i = 1; i <= n; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }
                else
                {
                    salary += 0;
                }
                   
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break; // to finish the cylce when salary <= 0
                }                               
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }           
        }
    }
}
