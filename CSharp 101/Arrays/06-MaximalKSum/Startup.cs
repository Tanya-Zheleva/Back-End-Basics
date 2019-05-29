namespace _06_MaximalKSum
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] elements = new int[n];

            for (int i = 0; i < n; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }

            int sum = elements
                .OrderByDescending(x => x)
                .Take(k)
                .Sum();

            Console.WriteLine(sum);
        }
    }
}
