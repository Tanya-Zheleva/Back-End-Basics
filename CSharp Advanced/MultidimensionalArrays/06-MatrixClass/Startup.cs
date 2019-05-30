namespace _06_MatrixClass
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());

            //Matrix<int> matrix = new Matrix<int>(n, m);
            Matrix matrix = new Matrix(3, 3);
            matrix[0, 0] = 5;
            matrix[1, 0] = 7;
            matrix[2, 2] = 8;

            Matrix matrix2 = new Matrix(3, 3);
            matrix2[0, 0] = 5;
            matrix2[1, 0] = 7;
            matrix2[2, 2] = 8;

            matrix *= matrix2;

            Console.WriteLine(matrix.ToString());
        }
    }
}
