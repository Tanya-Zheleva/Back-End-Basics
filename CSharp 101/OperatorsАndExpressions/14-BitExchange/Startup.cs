namespace _14_BitExchange
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            string binary = Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine($"Binary representation: {binary}");

            SwapBits(ref number, 24, 3);
            SwapBits(ref number, 25, 4);
            SwapBits(ref number, 26, 5);

            string binaryAfterSwap = Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine($"Binary representation after swap: {binaryAfterSwap}");
            Console.WriteLine(number);
        }

        private static void SwapBits(ref uint number, int firstPosition, int secondPosition)
        {
            uint firstMoved = 1u << firstPosition;
            uint secondMoved = 1u << secondPosition;

            uint firstValue = number & firstMoved;
            firstValue >>= firstPosition;

            uint secondValue = number & secondMoved;
            secondValue >>= secondPosition;

            if (firstValue == 1)
            {
                uint mask = 1u << secondPosition;
                number |= mask;
            }
            else
            {
                uint mask = ~(1u << secondPosition);
                number &= mask;
            }

            if (secondValue == 1)
            {
                uint mask = 1u << firstPosition;
                number |= mask;
            }
            else
            {
                uint mask = ~(1u << firstPosition);
                number &= mask;
            }
        }
    }
}
