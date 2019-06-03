namespace _01_SayHello
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
        }
    }
}
