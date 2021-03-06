﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGenric
{
    public class MaximumNumberCheck
    {
        /// <summary>
        /// Finds maximum is genric methode to find max number for integer,string,float values.
        /// </summary>
        /// <typeparam name="T"> T is Genric data type of int, float, string</typeparam>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns>maximum int number/maximum float number/maximum string</returns>
        /// <exception cref="Exception">firstValue,secondValue,thirdValue are same</exception>
        public static T findMaximum<T>(T firstValue,T secondValue,T thirdValue) where T : IComparable
        {
            if(firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
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
    }
}

