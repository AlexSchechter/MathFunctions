namespace MathFunctions
{
    public class Cube : IMathFunction
    {
        public double CalculateFunction(double value)
        {
            return value * value * value;
        }
    }
}
