namespace _14_HexToDecimal
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int power = 0;
            long decimalNumber = 0;

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int lastDigit = GetDecimalDigitFromHex(hex[i]);
                decimalNumber += lastDigit * GetPower(power);

                power++;
            }

            Console.WriteLine(decimalNumber);
        }

        private static int GetDecimalDigitFromHex(char digitSymbol)
        {
            string digits = "0123456789ABCDEF";

            return digits.IndexOf(digitSymbol);
        }

        private static long GetPower(int power)
        {
            if (power == 0)
            {
                return 1;
            }

            long result = 16;

            for (int i = 2; i <= power; i++)
            {
                result *= 16;
            }

            return result;
        }
    }
}
