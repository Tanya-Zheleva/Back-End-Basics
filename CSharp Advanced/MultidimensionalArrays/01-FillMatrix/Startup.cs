namespace _01_FillMatrix
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char fillType = char.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            switch (fillType)
            {
                case 'a':
                    FillByCols(n, matrix);
                    break;
                case 'b':
                    FillByZigZag(n, matrix);
                    break;
                case 'c':
                    FillByDiagonal(n, matrix);
                    break;
                case 'd':
                    FillBySpiral(n, matrix);
                    break;
                default:
                    break;
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

        private static void FillBySpiral(int n, int[,] matrix)
        {
            int endRow = n;
            int endCol = n;
            int startRow = 0;
            int startCol = 0;
            int value = 1;

            while (startRow < endRow && startCol < endCol)
            {
                for (int r = startRow; r < endRow; r++)
                {
                    matrix[r, startCol] = value;
                    value++;
                }

                startCol++;

                for (int c = startCol; c < endCol; c++)
                {
                    matrix[endRow - 1, c] = value;
                    value++;
                }

                endRow--;

                if (startCol < endCol)
                {
                    for (int r = endRow - 1; r >= startRow; r--)
                    {
                        matrix[r, endCol - 1] = value;
                        value++;
                    }

                    endCol--;

                    for (int c = endCol - 1; c >= startCol; c--)
                    {
                        matrix[startRow, c] = value;
                        value++;
                    }

                    startRow++;
                }
            }
        }

        private static void FillByDiagonal(int n, int[,] matrix)
        {
            int value = 1;

            for (int i = 0; i < n; i++)
            {
                int endCol = 0;

                for (int r = n - 1 - i; r < n; r++)
                {
                    matrix[r, endCol] = value;
                    value++;
                    endCol++;
                }
            }

            for (int i = 1; i < n; i++)
            {
                int startCol = i;

                for (int r = 0; r < n - i; r++)
                {
                    matrix[r, startCol] = value;
                    value++;
                    startCol++;
                }
            }
        }

        private static void FillByZigZag(int n, int[,] matrix)
        {
            int value = 1;
            int col = 0;

            while (value <= n * n)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = value;
                        value++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = value;
                        value++;
                    }
                }

                col++;
            }
        }

        private static void FillByCols(int n, int[,] matrix)
        {
            int value = 1;

            for (int c = 0; c < n; c++)
            {
                for (int r = 0; r < n; r++)
                {
                    matrix[r, c] = value;
                    value++;
                }
            }
        }
    }
}
