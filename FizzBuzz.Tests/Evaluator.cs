using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class Evaluator
    {
        [TestMethod]
        public void Evaluate_NeitherDivisibleByThreeNorFive_ReturnsNumber()
        {
            // arrange
            var expected = 2;

            // act
            var actual = FizzBuzz.Evaluator.Evaluate(expected);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(6)]
        public void Evaluate_DivisibleByThree_ReturnsFizz(int value)
        {
            // arrange
            var expected = "Fizz";

            // act
            var actual = FizzBuzz.Evaluator.Evaluate(value);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
