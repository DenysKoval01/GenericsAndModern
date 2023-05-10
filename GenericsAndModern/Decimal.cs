using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndModern
{
    public class Decimal : INumber
    {
        private readonly decimal _value;

        public Decimal(decimal value)
        {
            _value = value;
        }

        public INumber Add(INumber other)
        {
            return new Decimal(_value + ((Decimal)other)._value);
        }

        public INumber Subtract(INumber other)
        {
            return new Decimal(_value - ((Decimal)other)._value);
        }

        public INumber Multiply(INumber other)
        {
            return new Decimal(_value * ((Decimal)other)._value);
        }

        public INumber Divide(INumber other)
        {
            return new Decimal(_value / ((Decimal)other)._value);
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public static implicit operator Decimal(decimal value)
        {
            return new Decimal(value);
        }
    }
}
