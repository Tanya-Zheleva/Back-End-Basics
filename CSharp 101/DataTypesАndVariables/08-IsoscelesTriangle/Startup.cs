namespace _08_IsoscelesTriangle
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char symbol = '\u00A9';

            Console.WriteLine($"   {symbol}");
            Console.WriteLine();

            Console.WriteLine($"  {symbol} {symbol}");
            Console.WriteLine();

            Console.WriteLine($" {symbol}   {symbol}");
            Console.WriteLine();

            Console.WriteLine($"{symbol} {symbol} {symbol} {symbol}");
        }
    }
}
