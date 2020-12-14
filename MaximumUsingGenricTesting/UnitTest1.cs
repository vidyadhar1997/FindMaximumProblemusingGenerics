using FindMaximumUsingGenric;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumUsingGenricTesting
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the maximum number when integer at first position then return same number Using Genric Methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtFirstPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.findMaximum<int>(800, 700, 600);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when integer at second position then return same number Using Genric Methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtSecondPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.findMaximum<int>(700, 800, 600);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when integer at second position then return same number Using Genric Methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtThirdPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            int expected = 800;
            int maxNumber = MaximumNumberCheck.findMaximum<int>(700, 600, 800);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number is float when at first position then return same number Using Genric Methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtFirstPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            double expected = 70.0;
            double maxNumber = MaximumNumberCheck.findMaximum<double>(70.0,60.0,50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at second position then return same number Using Genric Methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtSecondPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            double expected = 70.0;
            double maxNumber = MaximumNumberCheck.findMaximum<double>(60.0, 70.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at third position then return same number Using Genric Methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtThirdPosition_ThenReturnSameNumberUsingGenricMethode()
        {
            double expected = 70.0;
            double maxNumber = MaximumNumberCheck.findMaximum<double>(60.0, 70.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum string when at first poistion then return same string Using Genric Methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtFirstPoistion_ThenReturnSameStringUsingGenricMethode()
        {
            string expected = "Peach";
            string maxString=MaximumNumberCheck.findMaximum<string>("Peach", "Apple", " Banana");
            Assert.AreEqual(expected,maxString);
        }

        /// <summary>
        /// Givens the maximum string when at second poistion then return same string Using Genric Methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtSecondPoistion_ThenReturnSameStringUsingGenricMethode()
        {
            string expected = "Peach";
            string maxString = MaximumNumberCheck.findMaximum<string>("Apple", "Peach", " Banana");
            Assert.AreEqual(expected, maxString);
        }

        /// <summary>
        /// Givens the maximum string when at third poistion then return same string Using Genric Methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtThirdPoistion_ThenReturnSameStringUsingGenricMethode()
        {
            string expected = "Peach";
            string maxString = MaximumNumberCheck.findMaximum<string>("Apple", "Banana", "Peach");
            Assert.AreEqual(expected, maxString);
        }

        /// <summary>
        /// Givens the maximum number when integer at first position then return same number Using Genric Class.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtFirstPosition_ThenReturnSameNumberUsingGenricClass()
        {
            int expected = 800;
            int maxNumber = GenricMaximum<int>.testMaximum(800, 700, 600);
            Assert.AreEqual(expected, maxNumber);
        }
        /// <summary>
        /// Givens the maximum number when integer at second position then return same number Using Genric Class.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtSecondPosition_ThenReturnSameNumberUsingGenricClass()
        {
            int expected = 800;
            int maxNumber = GenricMaximum<int>.testMaximum(700, 800, 600);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when integer at second position then return same number Using Genric Class.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerNumber_WhenAtThirdPosition_ThenReturnSameNumberUsingGenricClass()
        {
            int expected = 800;
            int maxNumber = GenricMaximum<int>.testMaximum(700, 600, 800);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number is float when at first position then return same number Using Genric Class.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtFirstPosition_ThenReturnSameNumberUsingGenricClass()
        {
            double expected = 70.0;
            double maxNumber = GenricMaximum<double>.testMaximum(70.0, 60.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at second position then return same number Using Genric Class.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtSecondPosition_ThenReturnSameNumberUsingGenricClass()
        {
            double expected = 70.0;
            double maxNumber = GenricMaximum<double>.testMaximum(60.0, 70.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at third position then return same number Using Genric Class.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_WhenAtThirdPosition_ThenReturnSameNumberUsingGenricClass()
        {
            double expected = 70.0;
            double maxNumber = GenricMaximum<double>.testMaximum(60.0, 70.0, 50.0);
            Assert.AreEqual(expected, maxNumber);
        }

        /// <summary>
        /// Givens the maximum string when at first poistion then return same string Using Genric Class.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtFirstPoistion_ThenReturnSameStringUsingGenricClass()
        {
            string expected = "Peach";
            string maxString = GenricMaximum<string>.testMaximum("Peach", "Apple", " Banana");
            Assert.AreEqual(expected, maxString);
        }

        /// <summary> 
        /// Givens the maximum string when at second poistion then return same string Using Genric Class.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtSecondPoistion_ThenReturnSameStringUsingGenricClass()
        {
            string expected = "Peach";
            string maxString = GenricMaximum<string>.testMaximum("Apple", "Peach", " Banana");
            Assert.AreEqual(expected, maxString);
        }

        /// <summary>
        /// Givens the maximum string when at third poistion then return same string Using Genric Class.
        /// </summary>
        [TestMethod]
        public void GivenMaxString_WhenAtThirdPoistion_ThenReturnSameStringUsingGenricClass()
        {
            string expected = "Peach";
            string maxString = GenricMaximum<string>.testMaximum("Apple", "Banana", "Peach");
            Assert.AreEqual(expected, maxString);
        }

        /// <summary>
        /// Givens the maximum number when integer at first position then return same number Using GenricClass and methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerArray_WhenAtLastPosition_ThenReturnSameNumberUsingGenricClassAndSorting()
        {
            int[] array = { 600, 700, 800,900 };
            int maxNumber = GenricMaximum<int>.maxValue(array);
            Assert.AreEqual(900, maxNumber);
        }

        /// <summary>
        /// Givens the maximum float number when at last position then return same number Using Genric Class and methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatArray_WhenAtLastPosition_ThenReturnSameNumberUsingGenricClassAndSorting()
        {
            double [] array= { 60.0,70.0, 80.0, 90.0 };
            double maxNumber = GenricMaximum<double>.maxValue(array);
            Assert.AreEqual(90.0, maxNumber);
        }

        /// <summary>
        /// Givens the maximum string when at last poistion then return same string Using Genric Class and methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxStringArray_WhenAtLastPoistion_ThenReturnSameStringUsingGenricClassAndSorting()
        {
            string [] array= { "Apple", "Banana", "Cat", "Peach" };
            string maxString = GenricMaximum<string>.maxValue(array);
            Assert.AreEqual("Peach", maxString);
        }

        /// <summary>
        /// Givens the maximum number when integer at last position then return same number Using Genric Class and methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerArray_WhenAtLastPosition_ThenReturnSameNumberUsingGenricClassAndMethod()
        {
            int[] array = { 600, 700, 800,900};
            GenricMaximum<int> findMaxGenricClass = new GenricMaximum<int>(600, 700, 800,array);
            int maxNumber=findMaxGenricClass.printMaxValue();
            Assert.AreEqual(900, maxNumber);
        }

        /// <summary>
        /// Givens the maximum number when float at last position then return same number Using Genric Class and methode.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerArray_WhenAtLastPosition_ThenReturnSameNumberUsingGenricClassAndMethods()
        {
            double[] array = { 60.0, 70.0, 80.0, 90.0 };
            GenricMaximum<double> findMaxGenricClass = new GenricMaximum<double>(60.0, 70.0, 80.0, array);
            double maxNumber = findMaxGenricClass.printMaxValue();
            Assert.AreEqual(90.0, maxNumber);
        }

        [TestMethod]
        public void GivenMaxStringArray_WhenAtLastPoistion_ThenReturnSameStringUsingGenricClassAndMethod()
        {
            string[] array = { "Apple", "Banana", "Cat", "Peach" };
            GenricMaximum<string> findMaxGenricClass = new GenricMaximum<string>("Apple", "Banana","Peach", array);
            string maxString = findMaxGenricClass.printMaxValue();
            Assert.AreEqual("Peach", maxString);
        }
    }
}
