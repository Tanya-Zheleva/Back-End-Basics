namespace _15_GCD
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int gcd = GetGCD(a, b);
            Console.WriteLine(gcd);
        }

        private static int GetGCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return GetGCD(b, a % b);
        }
    }
}
