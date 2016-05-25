using MathFunctions;
using NUnit.Framework;

namespace MathFunctionsTest
{
    [TestFixture]
    public class CubeTest
    {
        private Cube fCube;

        [TestCase(0, 0)]
        [TestCase(-1, -1)]
        [TestCase(-2, -8)]
        [TestCase(10, 1000)]
        public void CalculateFunctionReturnsCorrectResult(double inputValue, double expectedResult)
        {
            GivenSquareClass();
            ThenCalculateFunctionReturnsCorrectResult(inputValue, expectedResult);
        }

        private void GivenSquareClass()
        {
            fCube = new Cube();
        }

        private void ThenCalculateFunctionReturnsCorrectResult(double inputValue, double expectedResult)
        {
            Assert.That(expectedResult, Is.EqualTo(fCube.CalculateFunction(inputValue)));
        }
    }
}