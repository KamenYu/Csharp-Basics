using System;

namespace fruit_or_vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Плодовете & quot; fruit & quot; имат следните възможни стойности: banana, apple, kiwi, cherry, lemon и grapes
            //Зеленчуците & quot; vegetable & quot; имат следните възможни стойности: tomato, cucumber, pepper и carrot
            //Всички останали са & quot; unknown & quot;

            string plant = Console.ReadLine();

            switch (plant)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                            break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }



        }
    }
}
