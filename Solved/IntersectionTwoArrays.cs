using System.Collections.Generic;
using System.Linq;

/*
 https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/674/
    Given two integer arrays nums1 and nums2, 
    return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
    Input: nums1 = [1,2,2,1], nums2 = [2,2]
    Output: [2,2]
 */


namespace Problems.Solved
{
    public static class IntersectionTwoArrays
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0)
                return new int[0];

            if (nums1.Length <= nums2.Length)
                return GetIntersection(nums1, nums2);
            else
                return GetIntersection(nums2, nums1);
        }

        private static int[] GetIntersection(int[] smaller, int[] bigger)
        {
            var intersection = new Dictionary<int, int>(smaller.Length);

            foreach (var small in smaller)
            {
                for (int i = 0; i < bigger.Length; i++)
                {
                    if (small == bigger[i] && intersection.TryAdd(i, small))
                        break;
                }
            }

            return intersection.Values.ToArray();
        }
    }
}
