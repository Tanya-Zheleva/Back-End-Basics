namespace _05_ThirdDigit
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int thirdDigit = (number / 100) % 10;
            bool isThirdDigitSeven = thirdDigit == 7;

            if (isThirdDigitSeven)
            {
                Console.WriteLine(isThirdDigitSeven);
            }
            else
            {
                Console.WriteLine($"{isThirdDigitSeven} {thirdDigit}");
            }
        }
    }
}
