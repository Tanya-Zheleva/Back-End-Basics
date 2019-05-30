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
        }
    }
}
