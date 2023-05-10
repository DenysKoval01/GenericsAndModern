using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndModern
{
    public class Integer : INumber
    {
        private readonly int _value;

        public Integer(int value)
        {
            _value = value;
        }

        public INumber Add(INumber other)
        {
            return new Integer(_value + ((Integer)other)._value);
        }

        public INumber Subtract(INumber other)
        {
            return new Integer(_value - ((Integer)other)._value);
        }

        public INumber Multiply(INumber other)
        {
            return new Integer(_value * ((Integer)other)._value);
        }

        public INumber Divide(INumber other)
        {
            return new Integer(_value / ((Integer)other)._value);
        }

        public override string ToString()
        {
            return _value.ToString();
        }


        public static implicit operator Integer(int value)
        {
            return new Integer(value);
        }

    }
}
