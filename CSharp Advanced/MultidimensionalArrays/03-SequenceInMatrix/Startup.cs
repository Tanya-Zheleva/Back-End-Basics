namespace _03_SequenceInMatrix
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

            int rowSequence = GetMaxRowSequence(matrix);
            int colSequence = GetMaxColSequence(matrix);
            int mainDiagonalSequance = GetMaxMainDiagonalSequence(matrix);

            Console.WriteLine(rowSequence);
            Console.WriteLine(colSequence);
            Console.WriteLine(mainDiagonalSequance);
        }

        private static int GetMaxMainDiagonalSequence(int[][] matrix)
        {
            int best = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                int endCol = 0;
                int current = 1;

                for (int r = matrix.Length - 1 - i; r < matrix.Length - 1; r++)
                {
                    if (matrix[r][endCol] == matrix[r + 1][endCol + 1])
                    {
                        current++;
                    }
                    else
                    {
                        current = 1;
                    }

                    endCol++;
                }

                if (current > best)
                {
                    best = current;
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                int startCol = i;
                int current = 1;

                for (int r = 0; r < matrix.Length - i - 1; r++)
                {
                    if (matrix[r][startCol] == matrix[r + 1][startCol + 1])
                    {
                        current++;
                    }
                    else
                    {
                        current = 1;
                    }
                    startCol++;
                }

                if (current > best)
                {
                    best = current;
                }
            }

            return best;
        }

        private static int GetMaxColSequence(int[][] matrix)
        {
            int best = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                int current = 1;

                for (int col = 0; col < matrix[0].Length - 1; col++)
                {
                    if (matrix[row][col] == matrix[row][col + 1])
                    {
                        current++;
                    }
                    else
                    {
                        current = 1;
                    }
                }

                if (current > best)
                {
                    best = current;
                }
            }

            return best;
        }

        private static int GetMaxRowSequence(int[][] matrix)
        {
            int best = 0;

            for (int col = 0; col < matrix[0].Length; col++)
            {
                int current = 1;

                for (int row = 0; row < matrix.Length - 1; row++)
                {
                    if (matrix[row][col] == matrix[row + 1][col])
                    {
                        current++;
                    }
                    else
                    {
                        current = 1;
                    }
                }

                if (current > best)
                {
                    best = current;
                }
            }

            return best;
        }
    }
}
