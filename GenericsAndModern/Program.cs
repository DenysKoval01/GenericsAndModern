using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace GenericsAndModern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix<Double> m1 = new Matrix<Double>(new Double[,] { { 1.0, 2.0 }, { 3.0, 4.0 } });
            Matrix<Double> m2 = new Matrix<Double>(new Double[,] { { 5.0, 6.0 }, { 7.0, 8.0 } });

            Matrix<Double> result = m1.PerformOperation(m2, (x, y) => x.Add(y));
            Matrix<Double> result1 = m1.PerformOperation(m2, (x, y) => x.Multiply(y));


            WriteConsoleResultOfOperation(result);

            WriteConsoleResultOfOperation(result1);

        }

        private static void WriteConsoleResultOfOperation<T>(Matrix<T> matrix) where T : INumber
        {

            // print the result
            Console.WriteLine("\nResult:\n");
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write($"{matrix.GetElement(i, j)}  ");
                }
                Console.WriteLine();

            }
        }
    }
}