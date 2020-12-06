using System;
namespace mister_missis
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            // Mr. – мъж(пол &#39;m&#39;) на 16 или повече години
            // Master  – момче(пол &#39;m&#39;) под 16 години
            // Ms. – жена(пол &#39;f&#39;) на 16 или повече години
            // Miss – момиче(пол &#39;f&#39;) под 16 години

            if (age >= 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else  
                {
                    Console.WriteLine("Ms.");
                }

            }
            else
            {
                if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }




        }
    }
}
