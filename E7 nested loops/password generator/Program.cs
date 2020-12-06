using System;
namespace password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // CHECK the ascii table
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int symbol1 = 1; symbol1 <= n; symbol1++)  //•	Символ 1: цифра от 1 до n.
            {
                for (int symbol2 = 1; symbol2 <= n; symbol2++) //•	Символ 2: цифра от 1 до n.
                {
                    for (char symbol3 = 'a'; symbol3 < 'a' + l; symbol3++)   //•	Символ 3: малка буква измежду първите l букви на латинската азбука.
                    {
                        for (char symbol4 = 'a'; symbol4 < 'a' + l; symbol4++)  //•	Символ 4: малка буква измежду първите l букви на латинската азбука.
                        {
                            for (int symbol5 = 1; symbol5 <= n; symbol5++)  //•	Символ 5: цифра от 1 до n, по-голяма от първите 2 цифри.
                            {
                                if (symbol5 > symbol1 && symbol5 > symbol2)
                                {
                                    Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol5} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
