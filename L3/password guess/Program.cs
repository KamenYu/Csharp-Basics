using System;


namespace password_guess
{
    class Program
    {
        static void Main(string[] args)
        {
          // Start:
            // s3cr3t!P@ssw0rd
            string pass = Console.ReadLine();
            if (pass == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
          //  goto Start;
        }
    }
}
