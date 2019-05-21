namespace _09_MatrixOfNumbers
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startValue = 1;
            int row = 1;

            for (int i = 1; i <= n * n; i++)
            {
                Console.Write($"{startValue} ");
                startValue++;

                if (i % n == 0)
                {
                    Console.WriteLine();
                    row++;
                    startValue = row;
                }
            }

            Console.WriteLine();
        }
    }
}
