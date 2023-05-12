using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndModern
{
    public class Integer : INumber<Integer>
    {
        private int _value;

        public Integer(int value)
        {
            this._value = value;
        }

        public Integer Add(Integer number)
        {
            return new Integer(_value + (number)._value);
        }

        public Integer Divide(Integer number)
        {
            return new Integer(_value / (number)._value);
        }

        public Integer Multiply(Integer number)
        {
            return new Integer(_value * (number)._value);
        }

        public Integer Subtract(Integer number)
        {
            return new Integer(_value - (number)._value);
        }

        public override string ToString()
        {
            return _value.ToString();
        }

    }
}
