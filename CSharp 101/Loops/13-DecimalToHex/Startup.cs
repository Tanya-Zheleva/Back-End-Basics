namespace _13_DecimalToHex
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            StringBuilder hex = new StringBuilder();

            while (decimalNumber > 0)
            {
                long remain = decimalNumber % 16;
                hex.Append(GetHexCharacter(remain));

                decimalNumber /= 16;
            }

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                Console.Write(hex[i]);
            }

            Console.WriteLine();
        }

        private static char GetHexCharacter(long n)
        {
            char[] remainders = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            // Index will always be in range [0, 15] because of % 16
            return remainders[n];
        }
    }
}
