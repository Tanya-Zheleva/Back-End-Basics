namespace _04_BinarySearch
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            Array.Sort(elements);

            if (k >= elements[0])
            {
                int index = Array.BinarySearch(elements, k);

                while (index < 0)
                {
                    k--;
                    index = Array.BinarySearch(elements, k);
                }

                Console.WriteLine(elements[index]);
            }
            else
            {
                Console.WriteLine("No element found");
            }
        }
    }
}
