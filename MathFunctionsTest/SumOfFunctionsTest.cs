using MathFunctions;
using NUnit.Framework;
using System.Collections.Generic;


namespace MathFunctionsTest
{
    [TestFixture]
    public class SumOfFunctionsTest
    {
        private SumOfFunctions fSumOfFunctions;
        private Square fSquare1;
        private Square fSquare2;
        private Linear fLinear1;
        private Linear fLinear2;
        private Cube fCube1;
        private Cube fCube2;

        [TestCase(0, 0)]
        [TestCase(-1, 2)]
        [TestCase(2, 14)]
        public void CalculateFunctionReturnsTheCorrectSumOfFunctions(double inputValue, double expectedResult)
        {
            GivenListOfFunctions();
            AndSumOfFunctionsClassInitialisedWithTheseFunctions();
            ThenExecuteMethodSumsTheResultsOfEachFunction(inputValue, expectedResult);
        }

        [Test]
        public void ListOfMathFunctionsPropertyGetsTheCorrectListOfFunctions()
        {
            GivenListOfFunctions();
            AndSumOfFunctionsClassInitialisedWithTheseFunctions();
            ThenItGetsTheCorrectListOfFunctions();
        }

        [Test]
        public void AddMathFunctionAddsFunctionToListOfMathFunctionsProperty()
        {
            GivenListOfFunctions();
            AndSumOfFunctionsClassInitialisedWithTheseFunctions();
            AndFunctionToAdd();
            ThenPropertyGetsUpdatedCorrectlyWithTheAddMathFunctionMethod();
        }

        private void GivenListOfFunctions()
        {
            fSquare1 = new Square();
            fSquare2 = new Square();
            fLinear1 = new Linear(-2);
            fLinear2 = new Linear(1);
            fCube1 = new Cube();
        }

        private void AndSumOfFunctionsClassInitialisedWithTheseFunctions()
        {
            fSumOfFunctions = new SumOfFunctions(new List<IMathFunction>{ fSquare1, fSquare2, fLinear1, fLinear2, fCube1 });
        }

        private void AndFunctionToAdd()
        {
            fCube2 = new Cube();
        }

        private void ThenExecuteMethodSumsTheResultsOfEachFunction(double inputValue, double expectedResult)
        {
            Assert.AreEqual(expectedResult, fSumOfFunctions.CalculateFunction(inputValue));
        }

        private void ThenItGetsTheCorrectListOfFunctions()
        {
            CollectionAssert.AreEqual(new List<IMathFunction> { fSquare1, fSquare2, fLinear1, fLinear2, fCube1 }, fSumOfFunctions.ListOfMathFunctions);
        }

        private void ThenPropertyGetsUpdatedCorrectlyWithTheAddMathFunctionMethod()
        {
            fSumOfFunctions.AddMathFunction(fCube2);
            CollectionAssert.AreEqual(new List<IMathFunction> { fSquare1, fSquare2, fLinear1, fLinear2, fCube1, fCube2 }, fSumOfFunctions.ListOfMathFunctions);
        }
    }
}
