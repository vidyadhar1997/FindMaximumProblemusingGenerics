using FindMaximumUsingGenric;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumUsingGenricTesting
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the maximum number when integer at first position then return same number UsingGenricMethode.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtFirstPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.findMaximum<int>(800, 700, 600);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when integer at second position then return same number UsingGenricMethode.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtSecondPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.findMaximum<int>(700, 800, 600);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when integer at second position then return same number UsingGenricMethode.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtThirdPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.findMaximum<int>(700, 600, 800);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number is float when at first position then return same number UsingGenricMethode.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtFirstPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            double expected = 70.0;
            double maxNumber = MaximumNumberCheck.findMaximum<double>(70.0,60.0,50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at second position then return same number UsingGenricMethode.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtSecondPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            double expected = 70.0;
            double maxNumber = MaximumNumberCheck.findMaximum<double>(60.0, 70.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at third position then return same number UsingGenricMethode.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtThirdPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            double expected = 70.0;
            double maxNumber = MaximumNumberCheck.findMaximum<double>(60.0, 70.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum string when at first poistion then return same string UsingGenricMethode.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtFirstPoistion_ThenReturnSameStringUsingGenricMethode()
        {
            string expected = "Peach";
            string maxString=MaximumNumberCheck.findMaximum<string>("Peach", "Apple", " Banana");
            Assert.AreEqual(expected,maxString);
        }

        /// <summary>
        /// Givens the maximum string when at second poistion then return same string UsingGenricMethode.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtSecondPoistion_ThenReturnSameStringUsingGenricMethode()
        {
            string expected = "Peach";
            string maxString = MaximumNumberCheck.findMaximum<string>("Apple", "Peach", " Banana");
            Assert.AreEqual(expected, maxString);
        }

        /// <summary>
        /// Givens the maximum string when at third poistion then return same string UsingGenricMethode.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtThirdPoistion_ThenReturnSameStringUsingGenricMethode()
        {
            string expected = "Peach";
            string maxString = MaximumNumberCheck.findMaximum<string>("Apple", "Banana", "Peach");
            Assert.AreEqual(expected, maxString);
        }

        /// <summary>
        /// Givens the maximum number when integer at first position then return same number UsingGenricClass.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtFirstPosition_ThenReturnSameNumberUsingGenricClass()
        {
            int expected = 800;
            int maxNumber = GenricMaximum<int>.testMaximum(800, 700, 600);
            Assert.AreEqual(expected, maxNumber);
        }
        /// <summary>
        /// Givens the maximum number when integer at second position then return same number UsingGenricClass.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtSecondPosition_ThenReturnSameNumberUsingGenricClass()
        {
            int expected = 800;
            int maxNumber = GenricMaximum<int>.testMaximum(700, 800, 600);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when integer at second position then return same number UsingGenricClass.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtThirdPosition_ThenReturnSameNumberUsingGenricClass()
        {
            int expected = 800;
            int maxNumber = GenricMaximum<int>.testMaximum(700, 600, 800);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number is float when at first position then return same number UsingGenricClass.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtFirstPosition_ThenReturnSameNumberUsingGenricClass()
        {
            double expected = 70.0;
            double maxNumber = GenricMaximum<double>.testMaximum(70.0, 60.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at second position then return same number UsingGenricClass.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtSecondPosition_ThenReturnSameNumberUsingGenricClass()
        {
            double expected = 70.0;
            double maxNumber = GenricMaximum<double>.testMaximum(60.0, 70.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at third position then return same number UsingGenricClass.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtThirdPosition_ThenReturnSameNumberUsingGenricClass()
        {
            double expected = 70.0;
            double maxNumber = GenricMaximum<double>.testMaximum(60.0, 70.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum string when at first poistion then return same string UsingGenricClass.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtFirstPoistion_ThenReturnSameStringUsingGenricClass()
        {
            string expected = "Peach";
            string maxString = GenricMaximum<string>.testMaximum("Peach", "Apple", " Banana");
            Assert.AreEqual(expected, maxString);
        }

        /// <summary>
        /// Givens the maximum string when at second poistion then return same string UsingGenricClass.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtSecondPoistion_ThenReturnSameStringUsingGenricClass()
        {
            string expected = "Peach";
            string maxString = GenricMaximum<string>.testMaximum("Apple", "Peach", " Banana");
            Assert.AreEqual(expected, maxString);
        }

        /// <summary>
        /// Givens the maximum string when at third poistion then return same string UsingGenricMethode.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtThirdPoistion_ThenReturnSameStringUsingGenricClass()
        {
            string expected = "Peach";
            string maxString = GenricMaximum<string>.testMaximum("Apple", "Banana", "Peach");
            Assert.AreEqual(expected, maxString);
        }
    }
}
