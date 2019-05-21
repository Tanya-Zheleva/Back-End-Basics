namespace _11_BinaryToDecimal
{
    using System;
    using System.Numerics;

    public class Startup
    {
        public static void Main(string[] args)
        {
            BigInteger binary = BigInteger.Parse(Console.ReadLine());
            BigInteger decimalResult = 0;
            int power = 0;

            while (binary > 0)
            {
                BigInteger lastDigit = binary % 10;
                decimalResult += lastDigit * GetPowerOfTwo(power);

                power++;
                binary /= 10;
            }

            Console.WriteLine(decimalResult);
        }

        private static BigInteger GetPowerOfTwo(int power)
        {
            if (power == 0)
            {
                return 1;
            }

            BigInteger result = 2;

            for (int i = 2; i <= power; i++)
            {
                result *= 2;
            }

            return result;
        }
    }
}
