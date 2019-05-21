namespace _08_CatalanNumbers
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(1);

                return;
            }

            int p = 2 * n;
            int k = n;
            double result = 2*n;

            for (int i = p - 1; i >= k + 1; i--)
            {
                result *= i;
            }

            double toDivide = n + 1 == 1 ? 1 : 2;

            for (int i = n + 1; i > 2; i--)
            {
                toDivide *= i;
            }

            Console.WriteLine(result / toDivide);
        }
    }
}
