using FindMaximumUsingGenric;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumUsingGenricTesting
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the maximum number when at first position then return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxNumber_WhenAtFirstPosition_ThenReturnSameNumber()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.maximumIntegerNumber(800, 700, 600);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when at second position then return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxNumber_WhenAtSecondPosition_ThenReturnSameNumber()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.maximumIntegerNumber(700, 800, 600);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when at second position then return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxNumber_WhenAtThirdPosition_ThenReturnSameNumber()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.maximumIntegerNumber(700, 600, 800);
            Assert.AreEqual(expected, maxNumber);
        }
    }
}
