using System;

namespace Problems.Solved;

public class MaximumLengthValidSequence
{
    /* https://leetcode.com/problems/find-the-maximum-length-of-valid-subsequence-i/?envType=daily-question&envId=2025-07-16
    You are given an integer array nums.
    A subsequence sub of nums with length x is called valid if it satisfies:
    
    (sub[0] + sub[1]) % 2 == (sub[1] + sub[2]) % 2 == ... == (sub[x - 2] + sub[x - 1]) % 2.
    Return the length of the longest valid subsequence of nums.
    
    A subsequence is an array that can be derived from another array by deleting some or no elements without changing the order of the remaining elements.
    
    Example 1:
    Input: nums = [1,2,3,4]
    Output: 4
    Explanation:
    The longest valid subsequence is [1, 2, 3, 4].
    
    Example 2:
    Input: nums = [1,2,1,1,2,1,2]
    Output: 6
    Explanation:
    The longest valid subsequence is [1, 2, 1, 2, 1, 2].
    */


    public int MaximumLength(int[] nums)
    {
        int evens = 0, odds = 0, alternate = 1;
        bool wasLastEven = nums[0] % 2 == 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int n = nums[i];
            if (n % 2 == 0)
            {
                evens++;
                if (i != 0 && !wasLastEven)
                    alternate++;
                wasLastEven = true;
            }
            else
            {
                odds++;
                if (i != 0 && wasLastEven)
                    alternate++;
                wasLastEven = false;
            }
        }

        return Math.Max(Math.Max(evens, odds), alternate);
    }
}
