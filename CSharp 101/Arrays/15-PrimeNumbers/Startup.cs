namespace _15_PrimeNumbers
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];

            for (int i = 2; i * i <= n; i++)
            {
                if (!primes[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        primes[j] = true;
                    }
                }
            }

            for (int i = n; i >= 2; i--)
            {
                if (!primes[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
