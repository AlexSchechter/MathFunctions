using MathFunctions;
using NUnit.Framework;

namespace MathFunctionsTest
{
    [TestFixture]
    public class LinearTest
    {
        private Linear fLinear;

        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(5, 10, 50)]
        public void CalculateFunctionReturnsCorrectResult(double constant, double value, double result)
        {
            GivenLinearClass(constant);
            ThenCalculateFunctionReturnsCorrectResult(value, result);
        }

        private void GivenLinearClass(double constant)
        {
            fLinear = new Linear(constant);
        }

        private void ThenCalculateFunctionReturnsCorrectResult(double value, double result)
        {
            Assert.AreEqual(result, fLinear.CalculateFunction(value));
        }

    }
}
