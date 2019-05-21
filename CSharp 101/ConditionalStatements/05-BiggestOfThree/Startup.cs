namespace _05_BiggestOfThree
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double greater = a >= b ? a : b;
            double biggest = greater >= c ? greater : c;

            Console.WriteLine(biggest);
        }
    }
}
