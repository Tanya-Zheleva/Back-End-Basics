namespace _04_UnicodeCharacter
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            // Hex value of 42 = 2A;
            char symbol = '\u002A';

            Console.WriteLine(symbol);
        }
    }
}
