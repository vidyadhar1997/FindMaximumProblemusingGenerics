using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGenric
{
    public class GenricMaximum<T>where T:IComparable
    {
        public T firstValue, secondValue, thirdValue;

        /// <summary>
        /// Parameterized constructor Initializes a new instance of the <see cref="GenricMaximum{T}"/> class.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        public GenricMaximum(T firstValue,T secondValue,T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        /// <summary>
        /// Test maximum for find maximum value of int/float/string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns>maximum value int/float/string</returns>
        /// <exception cref="Exception">firstValue,secondValue,thirdValue are same</exception>
        public static T testMaximum<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0 ||
                thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
                thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue,secondValue,thirdValue are same");
        }

        /// <summary>
        /// Max method for print the maximum value.
        /// </summary>
        /// <returns>max int/string/float value</returns>
        public T maxMethod()
        {
            T max=GenricMaximum<T>.testMaximum(this.firstValue, this.secondValue, this.thirdValue);
            return max;
        }

        /// <summary>
        /// Max value methode for calling sort methode and return the last value of array.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>last value of array</returns>
        public T maxValue(params T[] values)
        {
            var sortedValues=Sort(values);
            return sortedValues[^1];
        }

        /// <summary>
        /// Sort methode in that
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        private T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
    }
}
