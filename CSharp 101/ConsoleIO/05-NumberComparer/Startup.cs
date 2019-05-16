namespace _05_NumberComparer
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double bigger = Math.Max(a, b);

            Console.WriteLine(bigger);
        }
    }
}
