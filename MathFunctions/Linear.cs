using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class Linear : IMathFunction
    {
        private readonly double fConstant;

        public Linear (double constant)
        {
            fConstant = constant;
        }

        public double CalculateFunction(double value)
        {
            return fConstant * value;
        }
    }
}
