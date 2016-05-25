using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class SumOfFunctions
    {
        private List<IMathFunction> MathFunctions;

        public SumOfFunctions(List<IMathFunction> mathFunctions)
        {
            MathFunctions = mathFunctions;
        }

        public double SumAllMathFunctionsResults (double value)
        {
            double result = 0;
            foreach (IMathFunction mathfunction in MathFunctions)
            {
                result += mathfunction.CalculateFunction(value);
            }
            return result;
        }

    }
}
