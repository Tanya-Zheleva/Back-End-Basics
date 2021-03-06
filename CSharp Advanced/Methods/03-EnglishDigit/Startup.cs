﻿namespace _03_EnglishDigit
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string lastDigitAsString = GetLastDigitAsString(number);

            Console.WriteLine(lastDigitAsString);
        }

        private static string GetLastDigitAsString(int number)
        {
            int digit = Math.Abs(number) % 10;

            switch (digit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "Not a number";
            }
        }
    }
}
