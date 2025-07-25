﻿using System;
using System.Collections.Generic;

namespace Problems.Solved;

public class LengthOfLongestSubstring
{
    /* https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
     Given a string s, find the length of the longest substring without duplicate characters.
Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
    
     */

    public int Run(string s)
    {
        Dictionary<char, int> characters = new(s.Length);
        int maxLen = 0;

        for (int i = 0, j = 0; j < s.Length; j++)
        {
            bool isFound = characters.TryGetValue(s[j], out int prevIndex);

            if (!isFound)
                characters.Add(s[j], j);
            else
            {
                characters[s[j]] = j;
                i = Math.Max(prevIndex + 1, i);
            }

            maxLen = Math.Max(maxLen, j - i + 1);
        }

        return maxLen;
    }
}
