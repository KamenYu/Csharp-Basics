using System;


namespace metric_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред: число за преобразуване - реално число
            // Втори ред: входна мерна единица - текст
            //Трети ред: изходна мерна единица(за резултата) - текст
            // 1m = 1000 mm
            // 1m = 100cm
        
            // because the units come from meter = convert the input to meters
            //and then the output to the other metrics and omit the meter
            double numberToConvert = double.Parse(Console.ReadLine());
            string enteredUnit = Console.ReadLine().ToLower();
            string exitUnit = Console.ReadLine().ToLower();
            
            if (enteredUnit == "cm" )
            {
                numberToConvert = numberToConvert * 0.01;
            }
            else if (enteredUnit == "mm")
            {
                numberToConvert = numberToConvert * 0.001;
            }
           //else if (enteredUnit == "m")
           // {
           //     numberToConvert = numberToConvert + 0;
           // }

            if (exitUnit == "cm")
            {
                numberToConvert = numberToConvert * 100;
            }
            else if (exitUnit == "mm")
            {
                numberToConvert = numberToConvert * 1000;
            }

            Console.WriteLine($"{ numberToConvert:f3}");
            Console.ReadLine();
           
        }
    }
}
