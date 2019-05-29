namespace _14_QuickSort
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

            QuickSort(elements, 0, elements.Length - 1);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }

        private static void QuickSort(int[] elements, int low, int high) 
        {
            if (low < high)
            {
                int partition = Partition(elements, low, high);

                QuickSort(elements, low, partition - 1);
                QuickSort(elements, partition + 1, high);
            }
        }

        private static int Partition(int[] elements, int low, int high) 
        {
            int pivot = elements[high];
            int index = low - 1;

            for (int j = low; j < high; j++)
            {
                if (elements[j].CompareTo(pivot) < 0)
                {
                    index++;

                    int temp = elements[index];
                    elements[index] = elements[j];
                    elements[j] = temp;
                }
            }

            int old = elements[index + 1];
            elements[index + 1] = elements[high];
            elements[high] = old;

            return index + 1;
        }
    }
}
