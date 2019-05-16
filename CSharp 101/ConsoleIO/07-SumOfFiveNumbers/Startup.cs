namespace _07_SumOfFiveNumbers
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                int current = int.Parse(Console.ReadLine());
                sum += current;
            }

            Console.WriteLine(sum);
        }
    }
}
