namespace _04_Rectangles
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter width and height:");
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = 2 * (width + height);

            Console.WriteLine($"{area:F2} {perimeter:F2}");
        }
    }
}
