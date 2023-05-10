using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndModern
{
    public interface INumber
    {
        INumber Add(INumber number);
        INumber Subtract(INumber number);
        INumber Multiply(INumber number);
        INumber Divide(INumber number);
    }

}
