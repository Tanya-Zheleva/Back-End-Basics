namespace _03_CompareCharArrays
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int result = first.CompareTo(second);

            if (result > 0)
            {
                Console.WriteLine('>');
            }
            else if (result < 0)
            {
                Console.WriteLine('<');
            }
            else
            {
                Console.WriteLine('=');
            }
        }
    }
}
