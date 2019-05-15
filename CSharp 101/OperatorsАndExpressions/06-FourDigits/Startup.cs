namespace _06_FourDigits
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            SumDigits(number);
            ReverseNumber(number);
            MakeLastDigitFirst(number);
            SwapDigits(number, 2, 3);
        }

        private static void MakeLastDigitFirst(int number)
        {
            int lastDigit = number % 10;
            number /= 10;
            number += lastDigit * 1000;

            Console.WriteLine($"{number:D4}");
        }

        private static void SwapDigits(int number, int firstPosition, int secondPosition)
        {
            // Counting starts from 0
            firstPosition--;
            secondPosition--;

            char[] digits = number.ToString().ToCharArray();

            char old = digits[firstPosition];
            digits[firstPosition] = digits[secondPosition];
            digits[secondPosition] = old;


            Console.WriteLine(string.Join("", digits));
        }

        private static void ReverseNumber(int number)
        {
            while (number > 0)
            {
                int lastDigit = number % 10;
                Console.Write(lastDigit);

                number /= 10;
            }

            Console.WriteLine();
        }

        private static void SumDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;

                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
