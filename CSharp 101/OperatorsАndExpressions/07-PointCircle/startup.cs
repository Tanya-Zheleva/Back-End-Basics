namespace _07_PointCircle
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double cX = 0;
            double cY = 0;
            double r = 2;

            double distance = Math.Sqrt((x - cX) * (x - cX) + (y - cY) * (y - cY));
            bool isIn = distance <= r;
            string conditionValue = isIn ? "yes" : "no";

            Console.WriteLine($"{conditionValue} {distance:F2}");
        }
    }
}
