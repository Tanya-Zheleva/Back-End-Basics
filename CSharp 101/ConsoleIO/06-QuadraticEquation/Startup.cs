namespace _06_QuadraticEquation
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - 4 * (a * c);

            if (discriminant > 0)
            {
                double d = Math.Sqrt(discriminant);

                double x1 = (-b + d) / (2 * a);
                double x2 = (-b - d) / (2 * a);

                if (x1 > x2)
                {
                    Console.WriteLine($"{x2:F2}");
                    Console.WriteLine($"{x1:F2}");
                }
                else
                {
                    Console.WriteLine($"{x1:F2}");
                    Console.WriteLine($"{x2:F2}");
                }
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"{x:F2}");
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
