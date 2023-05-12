using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndModern
{
    public class Double : INumber<Double>
    {
        private double _value;

        public Double(double value)
        {
            this._value = value;
        }

        public Double Add(Double number)
        {
            return new Double(_value + (number)._value);
        }

        public Double Subtract(Double number)
        {
            return new Double(_value - (number)._value);
        }

        public override string ToString()
        {
            return _value.ToString();
        }

    }
}
