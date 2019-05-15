namespace _15_BitSwap
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine($"Binary representation: {binary}");

            for (int i = 0; i < k; i++)
            {
                SwapBits(ref number, p, q);

                p++;
                q++;
            }

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
