namespace _17_SubsetKWithSumS
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToArray();
            int subsetElements = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            bool hasSum = false;

            for (int i = 0; i < elements.Length - 1; i++)
            {
                int currentSum = elements[i];
                int subsetCount = 1;

                for (int k = i + 1; k < elements.Length; k++)
                {
                    if (currentSum + elements[k] <= sum)
                    {
                        currentSum += elements[k];
                        subsetCount++;

                        if (currentSum == sum)
                        {
                            hasSum = true;
                        }

                        if (subsetCount > subsetElements)
                        {
                            break;
                        }
                    }
                }

                if (hasSum)
                {
                    break;
                }
            }

            if (hasSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
