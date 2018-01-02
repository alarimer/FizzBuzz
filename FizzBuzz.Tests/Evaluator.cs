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

        [TestMethod]
        public void Evaluate_DivisibleByThree_ReturnsFizz()
        {
            // arrange
            var expected = "Fizz";

            // act
            var actual = FizzBuzz.Evaluator.Evaluate(3);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Evaluate_DivisibleByThree_ReturnsFizz_1()
        {
            // arrange
            var expected = "Fizz";

            // act
            var actual = FizzBuzz.Evaluator.Evaluate(3);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
