using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace GenericsAndModern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two matrices of integers
            var matrix1 = new Matrix<Integer>(new Integer[,] { { new Integer(1), new Integer(2) }, { new Integer(3), new Integer(4) } });
            var matrix2 = new Matrix<Integer>(new Integer[,] { { new Integer(5), new Integer(6) }, { new Integer(7), new Integer(8) } });

            // Add the two matrices together
            var sumMatrix = matrix1.PerformOperation(matrix2, (x, y) => x.Add(y));

            // Print the resulting matrix
            Console.WriteLine("\nSum matrix:\n");
            PrintMatrix(sumMatrix);

            // Subtract matrix2 from matrix1
            var diffMatrix = matrix1.PerformOperation(matrix2, (x, y) => x.Subtract(y));

            // Print the resulting matrix
            Console.WriteLine("\nDifference matrix:\n");
            PrintMatrix(diffMatrix);

            // Multiply matrix1 and matrix2
            var productMatrix = matrix1.PerformOperation(matrix2, (x, y) => x.Multiply(y));

            // Print the resulting matrix
            Console.WriteLine("\nProduct matrix:\n");
            PrintMatrix(productMatrix);


            Console.ReadKey();
        }

        private static void PrintMatrix<T>(Matrix<T> matrix) where T : INumber<T>
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write(matrix.GetElement(i, j).ToString() + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }


    }
}