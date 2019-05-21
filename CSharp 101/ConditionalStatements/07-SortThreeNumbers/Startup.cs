namespace _07_SortThreeNumbers
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b > a) 
            {
                a = a + b;
                b = a - b;
                a -= b;
            }

            int c = int.Parse(Console.ReadLine());

            if (c > a)
            {
                a = a + c;
                c = a - c;
                a -= c;

                if (c > b)
                {
                    b = b + c;
                    c = b - c;
                    b -= c;
                }
            }
            else if (c > b)
            {
                b = b + c;
                c = b - c;
                b -= c;
            }

            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
