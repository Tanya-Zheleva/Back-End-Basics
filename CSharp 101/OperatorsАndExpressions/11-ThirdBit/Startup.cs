namespace _11_ThirdBit
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = 3;

            int mask = 1 << position;
            int bit = number & mask;
            bit >>= position;

            Console.WriteLine(bit);
        }
    }
}
