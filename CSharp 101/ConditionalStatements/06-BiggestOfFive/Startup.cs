namespace _06_BiggestOfFive
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            double biggest = a;

            double b = double.Parse(Console.ReadLine());

            if (biggest < b)
            {
                biggest = b;
            }

            double c = double.Parse(Console.ReadLine());

            if (biggest < c)
            {
                biggest = c;
            }

            double d = double.Parse(Console.ReadLine());

            if (biggest < d)
            {
                biggest = d;
            }

            double e = double.Parse(Console.ReadLine());

            if (biggest < e)
            {
                biggest = e;
            }

            Console.WriteLine(biggest);
        }
    }
}
