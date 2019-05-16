namespace _10_FibonacciNumbers
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 1;

            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                {
                    Console.Write($"{first}, ");
                }
                else
                {
                    Console.WriteLine($"{first}");

                    break;
                }

                int temp = first + second;
                first = second;
                second = temp;
            }
        }
    }
}
