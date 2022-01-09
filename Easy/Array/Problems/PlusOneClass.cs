using System;
using System.Collections.Generic;
using System.Text;

/*
 https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/559/
 You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
 The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

 Increment the large integer by one and return the resulting array of digits.
 */

namespace Array.Problems
{
    public static class PlusOneClass
    {
        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    break;
                }
                else
                {
                    digits[i] = 0;
                }
            }

            if (digits[0] == 0)
            {
                var newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;

                return newDigits;
            }

            return digits;
        }
    }
}
