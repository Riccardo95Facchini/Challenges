using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/549/
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
You must implement a solution with a linear runtime complexity and use only constant extra space.

Input: nums = [2,2,1]
Output: 1
 */

namespace Array.Problems
{
    public static class SingleNumberClass
    {
        // The right answer is left commented for reference
        public static int SingleNumber(int[] nums)
        {

            //What I should've done with an XOR
            //int res = 0;

            //for (int i = 0; i < nums.Count(); i++)
            //{
            //    res ^= nums[i];
            //}

            //return res;

            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            foreach (var num in nums)
            {

                if (!keyValues.TryAdd(num, num))
                    keyValues.Remove(num);

            }
            return keyValues.Keys.First();
        }




    }
}
