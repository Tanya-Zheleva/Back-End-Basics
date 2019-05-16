namespace _01_SumOfThreeNumbers
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            double sum = first + second + third;

            Console.WriteLine(sum);
        }
    }
}
