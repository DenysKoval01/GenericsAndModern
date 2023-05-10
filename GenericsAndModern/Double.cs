using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndModern
{
    public class Double : INumber
    {
        private readonly double _value;

        public Double(double value)
        {
            _value = value;
        }

        public INumber Add(INumber other)
        {
            return new Double(_value + ((Double)other)._value);
        }

        public INumber Subtract(INumber other)
        {
            return new Double(_value - ((Double)other)._value);
        }

        public INumber Multiply(INumber other)
        {
            return new Double(_value * ((Double)other)._value);
        }

        public INumber Divide(INumber other)
        {
            return new Double(_value / ((Double)other)._value);
        }

        public override string ToString()
        {
            return _value.ToString();
        }


        public static implicit operator Double(double value)
        {
            return new Double(value);
        }
    }

}
