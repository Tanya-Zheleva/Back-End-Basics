namespace _04_FormattingNumbers
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write($"{a.ToString("X"), -10}|{Convert.ToString(a, 2).PadLeft(10, '0')}|{b, 10:F2}|{c, -10:F3}|");

            Console.WriteLine();
        }
    }
}
