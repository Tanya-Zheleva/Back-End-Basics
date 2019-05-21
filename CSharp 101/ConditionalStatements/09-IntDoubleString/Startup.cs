namespace _09_IntDoubleString
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string readingType = Console.ReadLine();

            if (readingType == "integer")
            {
                int integer = int.Parse(Console.ReadLine());
                integer++;

                Console.WriteLine(integer);
            }
            else if (readingType == "real")
            {
                double real = double.Parse(Console.ReadLine());
                real++;

                Console.WriteLine($"{real:F2}");
            }
            else
            {
                string text = Console.ReadLine();

                Console.WriteLine($"{text}*");
            }
        }
    }
}
