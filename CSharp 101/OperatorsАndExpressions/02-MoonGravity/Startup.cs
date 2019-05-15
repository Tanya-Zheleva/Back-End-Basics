namespace _02_MoonGravity
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter weight: ");
            double weight = double.Parse(Console.ReadLine());

            double moonGravitationPercent = 0.17;
            double moonWeight = weight * moonGravitationPercent;

            Console.WriteLine($"{moonWeight:F3}");
        }
    }
}
