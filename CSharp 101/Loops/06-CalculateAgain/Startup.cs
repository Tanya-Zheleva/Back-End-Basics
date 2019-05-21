namespace _06_CalculateAgain
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            double result = n;

            for (int i = n - 1; i >= k + 1; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
