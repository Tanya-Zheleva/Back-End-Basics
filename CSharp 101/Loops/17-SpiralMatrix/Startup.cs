namespace _17_SpiralMatrix
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rowStart = 0;
            int rowEnd = n;
            int colStart = 0;
            int colEnd = n;
            int[,] matrix = new int[n, n];
            int value = 1;

            while (rowStart < rowEnd && colStart < colEnd)
            {
                for (int c = colStart; c < colEnd; c++)
                {
                    matrix[rowStart, c] = value;
                    value++;
                }

                rowStart++;

                for (int r = rowStart; r < rowEnd; r++)
                {
                    matrix[r, colEnd - 1] = value;
                    value++;
                }

                colEnd--;

                if (colStart < colEnd)
                {
                    for (int c = colEnd - 1; c >= colStart; c--)
                    {
                        matrix[rowEnd - 1, c] = value;
                        value++;
                    }

                    rowEnd--;
                }

                if (rowStart < rowEnd)
                {
                    for (int r = rowEnd - 1; r >= rowStart; r--)
                    {
                        matrix[r, colStart] = value;
                        value++;
                    }

                    colStart++;
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
