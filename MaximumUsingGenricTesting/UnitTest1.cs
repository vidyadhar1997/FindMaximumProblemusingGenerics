using FindMaximumUsingGenric;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumUsingGenricTesting
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the maximum number when integer at first position then return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtFirstPosition_ThenReturnSameNumber()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.maximumIntegerNumber(800, 700, 600);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when integer at second position then return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtSecondPosition_ThenReturnSameNumber()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.maximumIntegerNumber(700, 800, 600);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when integer at second position then return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtThirdPosition_ThenReturnSameNumber()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.maximumIntegerNumber(700, 600, 800);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number is float when at first position then return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtFirstPosition_ThenReturnSameNumber()
        {
            double expected = 70.0;
            double maxNumber = MaximumNumberCheck.maximumFloateNumber(70.0,60.0,50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at second position then return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtSecondPosition_ThenReturnSameNumber()
        {
            double expected = 70.0;
            double maxNumber = MaximumNumberCheck.maximumFloateNumber(60.0, 70.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at third position then return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtThirdPosition_ThenReturnSameNumber()
        {
            double expected = 70.0;
            double maxNumber = MaximumNumberCheck.maximumFloateNumber(60.0, 70.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }
        [TestMethod]
        public void GivenMaxString_WhenAtFirstPoistion_ThenReturnSameString()
        {
            string expected = "Peach";
            string maxString=MaximumNumberCheck.MaximumString("Peach", "Apple", " Banana");
            Assert.AreEqual(expected,maxString);
        }
    }
}
