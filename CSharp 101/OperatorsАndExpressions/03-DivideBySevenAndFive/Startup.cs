namespace _03_DivideBySevenAndFive
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            bool canDivide = number % 35 == 0;

            Console.WriteLine($"{canDivide} {number}");
        }
    }
}
