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
        [TestCase(1, -1, -1)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(-3, -2, 6)]
        [TestCase(5, 10, 50)]
        public void CalculateFunctionReturnsCorrectResult(double constant, double inputValue, double expectedResult)
        {
            GivenLinearClass(constant);
            ThenCalculateFunctionReturnsCorrectResult(inputValue, expectedResult);
        }

        private void GivenLinearClass(double constant)
        {
            fLinear = new Linear(constant);
        }

        private void ThenCalculateFunctionReturnsCorrectResult(double inputValue, double expectedResult)
        {
            Assert.AreEqual(expectedResult, fLinear.CalculateFunction(inputValue));
        }

    }
}
