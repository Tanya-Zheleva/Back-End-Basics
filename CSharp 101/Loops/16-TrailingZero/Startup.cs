namespace _16_TrailingZero
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int power = 1;
            long divider = 5;
            long zeros = 0;

            while (number / divider > 0)
            {
                zeros += number / divider;

                power++;
                divider = GetPowerOfFive(power);
            }

            Console.WriteLine(zeros);
        }

        private static long GetPowerOfFive(int power)
        {
            if (power == 0)
            {
                return 1;
            }

            long result = 5;

            for (int i = 2; i <= power; i++)
            {
                result *= 5;
            }

            return result;
        }
    }
}
