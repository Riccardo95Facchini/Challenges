using System;
using System.Collections.Generic;
using System.Text;

/*
 https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/567/
 
 Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
 Note that you must do this in-place without making a copy of the array.
 */

namespace Array.Problems
{
    public static class MoveZeroesClass
    {
        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1)
                return;

            int firstZeroIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    firstZeroIndex = firstZeroIndex >= 0 ? firstZeroIndex : i;
                else if (firstZeroIndex >= 0)
                {
                    nums[firstZeroIndex] = nums[i];
                    nums[i] = 0;
                    firstZeroIndex++;
                }
            }
        }
    }
}
