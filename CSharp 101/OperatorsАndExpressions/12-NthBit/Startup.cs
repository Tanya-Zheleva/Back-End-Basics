namespace _12_NthBit
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(number, 2).PadLeft(64, '0');
            Console.WriteLine($"Binary representation: {binary}");

            long mask = 1 << n;
            long bit = number & mask;
            bit >>= n;

            Console.WriteLine($"N-th bit: {bit}");
        }
    }
}
