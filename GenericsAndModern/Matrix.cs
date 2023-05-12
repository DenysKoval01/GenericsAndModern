using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndModern
{
    public class Matrix<T> where T : INumber<T>
    {
        private T[,] _values;

        public Matrix(T[,] values)
        {
            _values = values;
        }

        public int Rows => _values.GetLength(0);

        public int Columns => _values.GetLength(1);


        public Matrix<T> PerformOperation(Matrix<T> other, Func<T, T, T> operation)
        {
            T[,] result = new T[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    result[i, j] = (T)operation(_values[i, j], other._values[i, j]);
                }
            }

            return new Matrix<T>(result);
        }


        public T GetElement(int i, int j)
        {
            return _values[i, j];
        }
    }
}