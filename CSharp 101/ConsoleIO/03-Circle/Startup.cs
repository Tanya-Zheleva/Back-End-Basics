namespace _03_Circle
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine($"{perimeter:F2} {area:F2}");
        }
    }
}
