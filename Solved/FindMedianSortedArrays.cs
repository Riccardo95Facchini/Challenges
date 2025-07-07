using System;

namespace Problems.Solved;

public class FindMedianSortedArrays
{
    /* https://leetcode.com/problems/median-of-two-sorted-arrays/description/
     Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
     The overall run time complexity should be O(log (m+n)).

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.
Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
     */

    // Merges and then sorts the 2 arrays again, but it's O(m+n+log(m+n)) => O(log(m+n))
    public double RunMerge(int[] nums1, int[] nums2)
    {
        int totalLen = nums1.Length + nums2.Length;
        int[] added = new int[totalLen];
        nums1.CopyTo(added, 0);
        nums2.CopyTo(added, nums1.Length);
        Array.Sort(added);

        if (totalLen % 2 == 0)
            return (double)(added[(totalLen / 2) - 1] + added[(totalLen / 2)]) / 2;
        else
            return (double)added[((totalLen + 1) / 2) - 1];
    }

    // Binary search, by working on the smallest one we get O(log(min(m,n)))
    public double RunBinarySearch(int[] nums1, int[] nums2)
    {
        // We want to work on the smallest one, so if nums2 is shorter we swap them
        if (nums2.Length < nums1.Length)
            return RunBinarySearch(nums2, nums1);

        int m = nums1.Length;
        int n = nums2.Length;

        int start = 0;
        int end = m;

        // iterate on the shorter array so we use the two positions as the start and the end of the array
        while (start <= end)
        {
            int partition1 = (start + end) / 2; // pick midpoint of partition of array1
            int partition2 = ((m + n + 1) / 2) - partition1; // left and right partitions must have equal amount of values, the +1 is for odd totals it changes nothing on even

            // save max value left partition of first array (use -inf if we partitioned at 0)
            int maxLeft1 = partition1 == 0 ? int.MinValue : nums1[partition1 - 1];
            // save min value right partition of first array (use +inf if we partitioned at the end)
            int minRight1 = partition1 == m ? int.MaxValue : nums1[partition1];

            // save same values for second array
            int maxLeft2 = partition2 == 0 ? int.MinValue : nums2[partition2 - 1];
            int minRight2 = partition2 == n ? int.MaxValue : nums2[partition2];

            // If at the partition point we have the following condition, we know we have the 4 values needed for the median
            // ... 3 | 11 ... 
            // ... 9 | 15 ...
            // if for this means that (knowing all values before ar smaller and all values later are bigger) we are at the median point, it's clear once we write the combined array:
            // ... 3 9 11 15 ... if we had a 10 (the only value that could change the median) it would have been either between the 3 and 11 or the 9 and 15
            // this condition guarantees that we have the values needed for the median
            if (maxLeft1 <= minRight2 && maxLeft2 <= minRight1)
                return (m + n) % 2 == 0 ? (Math.Max(maxLeft1, maxLeft2) + Math.Min(minRight1, minRight2)) / 2.0 : Math.Max(maxLeft1, maxLeft2);
            // if maxLeft1 > minRight2 then we partitioned too far to the right, so we move the end search position to the current partition - 1 (therefore look more left)
            // in other words we want to search for a smaller element of maxLeft1, potentially until we hit -inf (or a bigger minRight2 until we hit +inf)
            else if (maxLeft1 > minRight2)
                end = partition1 - 1;
            // if maxLeft2 > minRight1 we partitioned too far to the left so we move the start search position to the current partition + 1 (therefore look more right)
            // in other words we want a bigger balue of minRight1 potentially until we hit +int (or a smaller maxLeft2 until we hit -inf)
            else if (maxLeft2 > minRight1)
                start = partition1 + 1;
        }

        throw new ArgumentException("Arrays are not ordered");
    }
}
