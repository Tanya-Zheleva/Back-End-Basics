namespace _14_PrintASCIITable
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 33; i <= 126; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
