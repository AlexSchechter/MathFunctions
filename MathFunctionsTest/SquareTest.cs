using MathFunctions;
using NUnit.Framework;

namespace MathFunctionsTest
{
    [TestFixture]
    public class SquareTest
    {
        private Square fSquare;

        [TestCase(0, 0)]
        [TestCase(-1, 1)]
        [TestCase(-2, 4)]
        [TestCase(10, 100)]
        public void CalculateFunctionReturnsCorrectResult(double inputValue, double expectedResult)
        {
            GivenSquareClass();
            ThenCalculateFunctionReturnsCorrectResult(inputValue, expectedResult);
        }

        private void GivenSquareClass()
        {
            fSquare = new Square();
        }

        private void ThenCalculateFunctionReturnsCorrectResult(double inputValue, double expectedResult)
        {
            Assert.That(expectedResult, Is.EqualTo(fSquare.CalculateFunction(inputValue)));
        }
    }
}
