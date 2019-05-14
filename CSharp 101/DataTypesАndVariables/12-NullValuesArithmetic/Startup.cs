namespace _12_NullValuesArithmetic
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int? a = null;
            double? b = null;

            Console.WriteLine($"Before arithmetics: a = {a}, b = {b}");

            a += 15;
            b += 7.24;

            Console.WriteLine($"After arithmetics: a = {a}, b = {b}");

            a = 15;
            b = 7.24;

            Console.WriteLine($"After = operator: a = {a}, b = {b}");
        }
    }
}
