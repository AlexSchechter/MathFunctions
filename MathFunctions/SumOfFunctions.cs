using System.Collections.Generic;

namespace MathFunctions
{
    public class SumOfFunctions : IMathFunction
    {
        private List<IMathFunction> fMathFunctions;

        public List<IMathFunction> ListOfMathFunctions
        {
            get { return fMathFunctions; }
        }

        public SumOfFunctions(List<IMathFunction> mathFunctions)
        {
            fMathFunctions = mathFunctions;
        }

        public double CalculateFunction(double value)
        {
            double result = 0;
            foreach (IMathFunction mathfunction in fMathFunctions)
            {
                result += mathfunction.CalculateFunction(value);
            }
            return result;
        }

        public void AddMathFunction(IMathFunction mathFunction)
        {
            fMathFunctions.Add(mathFunction);
        }
    }
}
