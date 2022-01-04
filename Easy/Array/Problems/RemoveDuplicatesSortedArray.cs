using System;

/*
https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/

Given an integer array nums sorted in non-decreasing order, 
remove the duplicates in-place such that each unique element appears only once. 
The relative order of the elements should be kept the same.

Since it is impossible to change the length of the array in some languages, 
you must instead have the result be placed in the first part of the array nums. 
More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. 
It does not matter what you leave beyond the first k elements.

Return k after placing the final result in the first k slots of nums.

Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
*/

namespace Array
{
    public static class RemoveDuplicatesSortedArray
    {

        // Substitution removed as it's not required and it saves a bit of time
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 0)
                return 0;

            int num = nums[0];
            int firstFreeIndex = -1;
            int k = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (num == nums[i])
                {
                    firstFreeIndex = firstFreeIndex < 0 ? i : firstFreeIndex;
                    //nums[i] = int.MinValue;
                }
                else
                {
                    k++;
                    num = nums[i];
                    if (firstFreeIndex > 0)
                    {
                        nums[firstFreeIndex] = num;
                        firstFreeIndex++;
                        //nums[i] = int.MinValue;
                    }
                }
            }
            return k;
        }
    }
}
