namespace _11_BinarySearch
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

            int x = int.Parse(Console.ReadLine());
            int index = BinarySearch(elements, 0, elements.Length - 1, x);

            Console.WriteLine(index);
        }

        private static int BinarySearch(int[] elements, int left, int right, int x)
        {
            if (left > right)
            {
                return -1;
            }

            int mid = (left + right) / 2;

            if (elements[mid] == x)
            {
                return mid;
            }

            if (elements[mid] > x)
            {
                return BinarySearch(elements, left, mid - 1, x);
            }

            return BinarySearch(elements, mid + 1, right, x);
        }
    }
}
