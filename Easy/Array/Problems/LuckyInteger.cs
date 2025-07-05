using System.Collections.Generic;

namespace Array.Problems;

/*
 Example 1:

Input: arr = [2,2,3,4]
Output: 2
Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
Example 2:

Input: arr = [1,2,2,3,3,3]
Output: 3
Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.
Example 3:

Input: arr = [2,2,2,3,3]
Output: -1
Explanation: There are no lucky numbers in the array.
 */

public class LuckyInteger
{
    public int FindLucky(int[] arr)
    {
        Dictionary<int, int> frequency = new() { { -1, -1 } };

        foreach (int i in arr)
        {
            if (frequency.TryGetValue(i, out _))
                frequency[i]++;
            else
                frequency.Add(i, 1);
        }

        int maxLucky = -1;

        foreach (var f in frequency)
        {
            if (f.Key == f.Value && f.Value > maxLucky)
                maxLucky = f.Value;
        }

        return maxLucky;
    }
}
