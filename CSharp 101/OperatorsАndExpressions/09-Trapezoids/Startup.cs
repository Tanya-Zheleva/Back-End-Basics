namespace _09_Trapezoids
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = (a + b) * h / 2;
            Console.WriteLine($"{area:F7}");
        }
    }
}
