namespace _09_ExchangeVariableValues
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before: a = {a}, b = {b}");

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine($"After: a = {a}, b = {b}");
        }
    }
}
