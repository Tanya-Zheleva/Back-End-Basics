namespace Age
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            DateTime bDay = DateTime.Parse(Console.ReadLine());
            TimeSpan diff = DateTime.Now.Subtract(bDay);
            int years = diff.Days / 365;

            Console.WriteLine($"Current age: {years}");
            Console.WriteLine($"Age after 10 years: {years + 10}");
        }
    }
}
