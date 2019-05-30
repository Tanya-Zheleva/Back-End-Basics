namespace _02_MaximalSum
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] dimesions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimesions[0];
            int cols = dimesions[1];
            int[][] matrix = new int[rows][];

            for (int r = 0; r < rows; r++)
            {
                matrix[r] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int bestSum = int.MinValue;

            for (int r = 0; r < rows - 2; r++)
            {
                for (int c = 0; c < cols - 2; c++)
                {
                    int currentSum = matrix[r][c] + matrix[r][c + 1] + matrix[r][c + 2] +
                        matrix[r + 1][c] + matrix[r + 1][c + 1] + matrix[r + 1][c + 2] +
                        matrix[r + 2][c] + matrix[r + 2][c + 1] + matrix[r + 2][c + 2];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }

            Console.WriteLine(bestSum);
        }    
    }
}
