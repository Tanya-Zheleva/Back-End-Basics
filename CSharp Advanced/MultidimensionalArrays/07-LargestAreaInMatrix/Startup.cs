namespace _07_LargestAreaInMatrix
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] dimesions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimesions[0];
            int cols = dimesions[1];
            int[][] matrix = new int[rows][];

            for (int r = 0; r < rows; r++)
            {
                matrix[r] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            bool[][] visited = new bool[rows][];

            for (int r = 0; r < rows; r++)
            {
                visited[r] = new bool[cols];

                for (int c = 0; c < cols; c++)
                {
                    visited[r][c] = false;
                }
            }

            int maxArea = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    int value = matrix[r][c];
                    int currentArea = SearchMatrix(value, r, c, matrix, visited);

                    if (currentArea > maxArea)
                    {
                        maxArea = currentArea;
                    }
                }
            }

            Console.WriteLine(maxArea);
        }

        private static int SearchMatrix(int value, int row, int col, int[][] matrix, bool[][] visited)
        {
            bool isOutOfRange = row < 0 || row >= matrix.Length || col < 0 || col >= matrix[0].Length;

            if (isOutOfRange || visited[row][col] || matrix[row][col] != value)
            {
                return 0;
            }

            visited[row][col] = true;

            return SearchMatrix(value, row, col + 1, matrix, visited) + // Check right
                SearchMatrix(value, row, col - 1, matrix, visited) + // Check left
                SearchMatrix(value, row + 1, col, matrix, visited) + // Check botton
                SearchMatrix(value, row - 1, col, matrix, visited) + 1; // Check top
        }
    }
}
