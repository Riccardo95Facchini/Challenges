using System.Collections.Generic;

/*
 https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/578/

 Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    Input: nums = [1,2,3,1]
    Output: true
 */

namespace Problems.Solved
{
    public static class ContainsDuplicateClass
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length < 2)
                return false;

            HashSet<int> set = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!set.Add(num))
                    return true;
            }

            return false;
        }
    }
}
