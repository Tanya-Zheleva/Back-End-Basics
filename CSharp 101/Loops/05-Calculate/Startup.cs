namespace _05_Calculate
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                long factorial = GetFactorial(i);
                double power = GetPower(x, i);

                sum += factorial / power;
            }

            Console.WriteLine($"{sum:F5}");
        }

        private static double GetPower(double x, int n)
        {
            double result = x;

            for (int i = 2; i <= n; i++)
            {
                result *= x;
            }

            return result;
        }

        private static long GetFactorial(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            long result = 2;

            for (int i = 3; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
