namespace _01_NumbersOneToN
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
