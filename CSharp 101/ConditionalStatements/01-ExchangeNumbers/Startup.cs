namespace _01_ExchangeNumbers
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                double oldA = a;
                a = b;
                b = oldA;
            }

            Console.WriteLine($"{a} {b}");
        }
    }
}
