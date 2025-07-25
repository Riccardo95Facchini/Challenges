using System;

namespace Problems.Solved;

public class ContainerWithMostWater
{
    // https://leetcode.com/problems/container-with-most-water/
    /*
     You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
     Find two lines that together with the x-axis form a container, such that the container contains the most water.
     Return the maximum amount of water a container can store.
     Notice that you may not slant the container.
     */

    public int MaxArea(int[] height)
    {
        int maxVolume = 0;

        for (int i = 0, j = height.Length - 1; i < j;)
        {
            maxVolume = Math.Max(maxVolume, Math.Min(height[i], height[j]) * (j - i));
            if (height[i] >= height[j])
                j--;
            else
                i++;
        }

        return maxVolume;
    }
}
