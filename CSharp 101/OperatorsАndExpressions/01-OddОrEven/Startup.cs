namespace _01_OddОrEven
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            string type = number % 2 == 0 ? "even" : "odd";

            Console.WriteLine($"{type} {number}");
        }
    }
}
