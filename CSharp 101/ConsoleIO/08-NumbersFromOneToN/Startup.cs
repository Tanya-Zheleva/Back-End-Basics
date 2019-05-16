namespace _08_NumbersFromOneToN
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                // All one one line for judge
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
