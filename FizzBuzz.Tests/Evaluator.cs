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
            var goal = 0;

            // act
            var result = 1;

            // assert
            Assert.AreEqual(result, goal);
        }
    }
}
