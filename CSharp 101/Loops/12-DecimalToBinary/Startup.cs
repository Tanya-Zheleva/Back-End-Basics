namespace _12_DecimalToBinary
{
    using System;
    using System.Numerics;

    public class Startup
    {
        public static void Main(string[] args)
        {
            BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine());
            int power = 0;
            BigInteger binary = 0;

            while (decimalNumber > 0)
            {
                BigInteger remain = decimalNumber % 2;
                binary += remain * GetPowerOfTen(power);

                power++;
                decimalNumber /= 2;
            }

            Console.WriteLine(binary);
        }

        private static BigInteger GetPowerOfTen(int power)
        {
            if (power == 0)
            {
                return 1;
            }

            BigInteger result = 10;

            for (int i = 2; i <= power; i++)
            {
                result *= 10;
            }

            return result;
        }
    }
}
