namespace _07_LargestAreaInMatrix
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

            int best = 0;
            SearchMatrix(0, 0, matrix, ref best);
        }

        private static void SearchMatrix(int row, int col, int[][] matrix, ref int best)
        {
            if (row >= matrix.Length || col >= matrix[0].Length || row < 0 || col < 0)
            {
                return;
            }

            if (row + 1 < matrix.Length)
            {
                SearchMatrix(row + 1, col, matrix, ref best);
            }

            if (col + 1 < matrix[0].Length)
            {
                SearchMatrix(row, col + 1, matrix, ref best);
            }

            if (col - 1 > 0)
            {
                SearchMatrix(row, col - 1, matrix, ref best);
            }


        }
    }
}
