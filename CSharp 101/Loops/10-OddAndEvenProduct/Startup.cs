namespace _10_OddAndEvenProduct
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int evenProduct = numbers[0];
            int oddProduct = numbers[1];

            for (int i = 2; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    evenProduct *= numbers[i];
                }
                else
                {
                    oddProduct *= numbers[i];
                }
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine($"yes {evenProduct}");
            }
            else
            {
                Console.WriteLine($"no {oddProduct} {evenProduct}");
            }
        }
    }
}
