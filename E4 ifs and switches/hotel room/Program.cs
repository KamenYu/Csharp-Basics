using System;

namespace hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {
            //string month = Console.ReadLine();
            //double nights = double.Parse(Console.ReadLine());
            //double priceStudio = 0.0;
            //double priceApartment = 0.0;

            //if (month == "May" || month == "October")
            //{
            //    if (nights <= 14 && nights > 7)
            //    {
            //        priceStudio = (nights * 50) - (nights * 50 * 0.05);                  
            //    }
            //    else if (nights > 14)
            //    {
            //        priceStudio = (nights * 50) - (nights * 50 * 0.3);
            //        priceApartment = (nights * 65) - (nights * 65 * 0.1);
            //    }
            //    else
            //    {
            //        priceStudio = nights * 50;
            //        priceApartment = nights * 65;
            //    }               
            //}
            //else if (month == "June" || month == "September")
            //{
            //    if (nights > 14)
            //    {
            //        priceStudio = (nights * 75.20) - (nights * 75.20 * 0.2);
            //        priceApartment = (nights * 68.70) - (nights * 68.70 * 0.1);
            //    }
            //    else
            //    {
            //        priceStudio = nights * 75.20;
            //        priceApartment = nights * 68.70;
            //    }
            //}
            //else if (month == "July" || month == "August")
            //{
            //    if (nights > 14)
            //    {
            //        priceApartment = (nights * 77) - (nights * 77 * 0.1);
            //    }
            //    else
            //    {
            //        priceApartment = nights * 77;
            //    }
            //    priceStudio = nights * 76;
            //}
            //Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            //Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            //// <script src="https://pastebin.com/embed_js/vN0Vi7Fw"></script>
            //  static void Main(string[] args)
            //{
            string month = Console.ReadLine();
            //May, June, July, August, September или October
            int nights = int.Parse(Console.ReadLine());

            //1. Крайна цена  
            // крайна цена за студио = нощувки * ед. цена за студио
            //крайна цена за апартамент = нощувки * ед.цена за апартамент
            double priceStudio = 0;
            double priceApartment = 0;


            //проверка Май и октомври
            if (month == "May" || month == "October")
            {
                priceStudio = nights * 50;
                priceApartment = nights * 65;
                //намаление
                if (nights > 7 && nights <= 14)
                {
                    priceStudio = priceStudio - 0.05 * priceStudio;
                    //0.95 * priceStudio
                }
                else if (nights > 14)
                {
                    priceStudio = priceStudio - 0.30 * priceStudio;
                    //0.7 * priceStudio
                }


            }
            else if (month == "June" || month == "September")
            {
                priceStudio = nights * 75.20;
                priceApartment = nights * 68.70;
                if (nights > 14)
                {
                    priceStudio = priceStudio - 0.20 * priceStudio;
                    //0.8 * priceStudio
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = nights * 76;
                priceApartment = nights * 77;
            }


            if (nights > 14)
            {
                priceApartment = priceApartment - 0.10 * priceApartment;
            }

            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");

        }
        }
}









