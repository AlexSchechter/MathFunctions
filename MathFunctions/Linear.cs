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
