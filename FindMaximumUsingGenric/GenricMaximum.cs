using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGenric
{
    public class GenricMaximum<T>where T:IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public T[] value;

        /// <summary>
        /// Parameterized constructor Initializes a new instance of the <see cref="GenricMaximum{T}"/> class.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        public GenricMaximum(T firstValue,T secondValue,T thirdValue,T[] value)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
            this.value = value;
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
        /// Sort methode in that
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public static T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        /// <summary>
        /// Max value methode for calling sort methode and return the last value of array.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>last value of array</returns>
        public static T maxValue(params T[] values)
        {
            T[] sortedValues=Sort(values);
            return sortedValues[^1];
        }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static T GetMaxValue(params T[] value)
        {
            T max = maxValue(value);
            return max;
        }

        /// <summary>
        /// Prints the maximum value.
        /// </summary>
        /// <returns></returns>
        public T printMaxValue()
        {
            return GenricMaximum<T>.GetMaxValue(this.value);
        }
    }
}
