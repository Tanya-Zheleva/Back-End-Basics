namespace _13_MergeSort
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

            MergeSort(elements, 0, elements.Length - 1);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }

        private static void MergeSort(int[] elements, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int mid = (left + right) / 2;

            MergeSort(elements, left, mid);
            MergeSort(elements, mid + 1, right);
            Merge(elements, left, mid, right);
        }

        public static void Merge(int[] elements, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;

            int[] leftPart = new int[leftSize];
            int[] rightPart = new int[rightSize];

            for (int i = 0; i < leftSize; i++)
            {
                leftPart[i] = elements[left + i];
            }

            for (int i = 0; i < rightSize; i++)
            {
                rightPart[i] = elements[mid + 1 + i];
            }

            int leftIndex = 0;
            int rightIndex = 0;
            int currentPosition = left;

            while (leftIndex < leftSize && rightIndex < rightSize)
            {
                if (leftPart[leftIndex] <= rightPart[rightIndex])
                {
                    elements[currentPosition] = leftPart[leftIndex];

                    leftIndex++;
                }
                else
                {
                    elements[currentPosition] = rightPart[rightIndex];

                    rightIndex++;
                }

                currentPosition++;
            }

            while (leftIndex < leftSize)
            {
                elements[currentPosition] = leftPart[leftIndex];

                leftIndex++;
                currentPosition++;
            }

            while (rightIndex < rightSize)
            {
                elements[currentPosition] = rightPart[rightIndex];

                rightIndex++;
                currentPosition++;
            }
        }
    }
}
