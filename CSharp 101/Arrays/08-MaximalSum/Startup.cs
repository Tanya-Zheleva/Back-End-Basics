namespace _08_MaximalSum
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] elements = new int[n];

            for (int i = 0; i < n; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }

            int max = int.MinValue;
            int currentMax = 0;

            for (int i = 0; i < n; i++)
            {
                currentMax += elements[i];

                if (currentMax > max)
                {
                    max = currentMax;
                }

                if (currentMax < 0)
                {
                    currentMax = 0;
                }
            }


            Console.WriteLine(max);
        }
    }
}
