using System;
using System.Collections.Generic;
using System.Text;

/*
 * https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
 Given an array, rotate the array to the right by k steps, where k is non-negative.

Input: nums = [1,2,3,4,5,6,7], k = 3
Output:       [5,6,7,1,2,3,4]

Input: nums = [-1,-100,3,99], k = 2
Output:       [3,99,-1,-100]

Input: nums = [-1,-100,3,99], k = 3
Output:       [-100,3,99,-1]
 
 */

namespace Array.Problems
{
    public static class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            k %= nums.Length;

            if (k == 0 || nums.Length < 2)
                return;


            int nextStash;
            int swapped = 0;

            for (int i = 0; i < nums.Length && swapped < nums.Length; i++)
            {
                int previousStash = nums[i];
                int swapIndex = i + k;
                while (swapIndex != i && swapped < nums.Length)
                {
                    nextStash = nums[swapIndex];
                    nums[swapIndex] = previousStash;
                    previousStash = nextStash;
                    swapIndex = (swapIndex + k) % nums.Length;
                    swapped++;
                }

                nums[swapIndex] = previousStash;
                swapped++;
            }

        }

        // Too slow
        public static void RotateSlow(int[] nums, int k)
        {
            k %= nums.Length;

            if (k == 0 || nums.Length < 2)
                return;

            for (int j = 0; j < k; j++)
            {
                int stash;
                int previous = nums[nums.Length - 1];

                for (int i = 0; i < nums.Length; i++)
                {
                    stash = nums[i];
                    nums[i] = previous;
                    previous = stash;
                }
            }
        }
    }
}
