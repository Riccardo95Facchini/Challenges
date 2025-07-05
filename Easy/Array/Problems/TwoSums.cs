namespace Array.Problems;

public class TwoSums
{
    /*
     Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
     You may assume that each input would have exactly one solution, and you may not use the same element twice.     
     You can return the answer in any order.

     Example 1:
     
     Input: nums = [2,7,11,15], target = 9
     Output: [0,1]
     Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
     Example 2:
     
     Input: nums = [3,2,4], target = 6
     Output: [1,2]
     Example 3:
     
     Input: nums = [3,3], target = 6
     Output: [0,1]
     */

    public int[] FindTwoSum(int[] nums, int target)
    {
        int pos1 = 0, pos2 = 1;

        for (; pos1 < nums.Length; pos2++)
        {
            if (pos2 == nums.Length)
            {
                pos1++;
                pos2 = pos1 + 1;
            }

            if (nums[pos1] + nums[pos2] == target)
                break;
        }

        return [pos1, pos2];
    }
}
