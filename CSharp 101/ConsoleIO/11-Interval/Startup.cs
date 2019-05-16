namespace _11_Interval
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int divisibleCount = 0;

            for (int i = n + 1; i < m; i++)
            {
                if (i % 5 == 0)
                {
                    divisibleCount++;
                }
            }

            Console.WriteLine(divisibleCount);
        }
    }
}
