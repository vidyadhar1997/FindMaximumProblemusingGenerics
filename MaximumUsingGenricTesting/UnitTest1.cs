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
        [TestMethod]
        public void GivenMaxNumber_WhenAtSecondPosition_ThenReturnSameNumber()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.maximumIntegerNumber(700, 800, 600);
            Assert.AreEqual(expected, maxNumber);
        }
    }
}
