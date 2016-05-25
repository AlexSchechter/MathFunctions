using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class Square : IMathFunction
    {
        public double CalculateFunction (double value)
        {
            return value * value;
        }
    }
}
