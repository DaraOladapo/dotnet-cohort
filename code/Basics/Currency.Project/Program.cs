using System;

namespace Currency.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to currency converter. Enter U for USD input and G for GBP input");
            var conversionChoice = Console.ReadLine();

            if (conversionChoice.ToUpper() == "U" || conversionChoice.ToUpper() == "G")
            {
                Console.WriteLine("Enter your amount");
                var conversionValue = decimal.Parse(Console.ReadLine());
                Convert(conversionValue, conversionChoice);
            }
            else
                Console.WriteLine("Bad input");
        }

        private static void Convert(decimal conversionValue, string conversionChoice)
        {
            switch (conversionChoice.ToUpper())
            {
                case "U":
                    Console.WriteLine($"£{Library.Currency.ConvertToGBP(conversionValue)}");
                    break;
                case "G":
                    Console.WriteLine($"${Library.Currency.ConvertToUSD(conversionValue)}");
                    break;
            }
        }
    }
}
