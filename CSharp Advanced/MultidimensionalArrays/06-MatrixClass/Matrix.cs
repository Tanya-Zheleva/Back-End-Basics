namespace _06_MatrixClass
{
    using System;
    using System.Text;

    public class Matrix
    {
        private int[,] elements; // Т[][]
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.elements = new int[this.rows, this.cols];
        }

        public int this[int row, int col]
        {
            get
            {
                return this.elements[row, col];
            }

            set
            {
                this.elements[row, col] = value;
            }
        }

        public static Matrix operator+(Matrix first, Matrix second)
        {
            if (first.GetLength(0) != second.GetLength(0) || first.GetLength(1) != second.GetLength(1))
            {
                throw new ArgumentException("Matrices must be of equal dimensions");
            }

            Matrix result = new Matrix(first.GetLength(0), second.GetLength(1));

            for (int r = 0; r < first.GetLength(0); r++)
            {
                for (int c = 0; c < first.GetLength(1); c++)
                {
                    result[r, c] = first[r, c] + second[r, c];
                }
            }

            return result;
        }

        public static Matrix operator-(Matrix first, Matrix second)
        {
            if (first.GetLength(0) != second.GetLength(0) || first.GetLength(1) != second.GetLength(1))
            {
                throw new ArgumentException("Matrices must be of equal dimensions");
            }

            Matrix result = new Matrix(first.GetLength(0), second.GetLength(1));

            for (int r = 0; r < first.GetLength(0); r++)
            {
                for (int c = 0; c < first.GetLength(1); c++)
                {
                    result[r, c] = first[r, c] - second[r, c];
                }
            }

            return result;
        }

        public static Matrix operator*(Matrix first, Matrix second)
        {
            if (first.GetLength(0) != second.GetLength(1))
            {
                throw new ArgumentException("First matrix rows must be equal to second matrix  cols");
            }

            Matrix result = new Matrix(first.GetLength(0), second.GetLength(1));

            for (int r = 0; r < first.GetLength(0); r++)
            {
                for (int c = 0; c < second.GetLength(1); c++)
                {
                    for (int i = 0; i < first.GetLength(0); i++)
                    {
                        result[r, c] += first[r, i] * second[i, c];
                    }
                }
            }

            return result;
        }

        public int GetLength(int dimension)
        {
            if (dimension < 0 || dimension > 1)
            {
                throw new ArgumentException("Matrix has only two dimesions");
            }

            return dimension == 0 ? this.rows : this.cols;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.rows; row++)
            {
                for (int col = 0; col < this.cols; col++)
                {
                    result.Append($"{this.elements[row, col]} ");
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
