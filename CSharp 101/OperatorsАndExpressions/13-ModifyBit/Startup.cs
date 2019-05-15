namespace _13_ModifyBit
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(number, 2).PadLeft(64, '0');
            Console.WriteLine($"Binary representation: {binary}");

            if (value == 1)
            {
                long mask = 1 << position;
                number |= mask;
            }
            else
            {
                long mask = ~(1 << position);
                number &= mask;
            }

            string binaryAfterSwap = Convert.ToString(number, 2).PadLeft(64, '0');
            Console.WriteLine($"Binary representation after swap: {binaryAfterSwap}");
            Console.WriteLine(number);
        }
    }
}
