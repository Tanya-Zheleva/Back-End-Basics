namespace _08_PrimeCheck
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);
            Console.WriteLine(isPrime);
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            double root = Math.Sqrt(number);

            for (int i = 3; i <= root; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
