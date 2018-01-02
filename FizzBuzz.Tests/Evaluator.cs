using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class Evaluator
    {
        [TestMethod]
        public void Method_Scenario_Expectation()
        {
            // arrange
            var expected = 0;

            // act
            var actual = 1;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
