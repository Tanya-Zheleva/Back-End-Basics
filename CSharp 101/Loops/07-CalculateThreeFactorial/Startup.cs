namespace _07_CalculateThreeFactorial
{
    using System;
    using System.Numerics;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger result = n;

            for (int i = n - 1; i >= k + 1; i--)
            {
                result *= i;
            }

            BigInteger toDivide = n - k == 1 ? 1 : 2;

            for (int i = n - k; i > 2; i--)
            {
                toDivide *= i;
            }

            Console.WriteLine(result / toDivide);
        }
    }
}
