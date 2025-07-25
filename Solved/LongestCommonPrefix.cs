namespace Problems.Solved;

public class LongestCommonPrefix
{
    // https://leetcode.com/problems/longest-common-prefix/
    /*
     Write a function to find the longest common prefix string amongst an array of strings.
     If there is no common prefix, return an empty string "".
     */

    public string Run(string[] strs)
    {
        string longest = strs[0];
        if (strs.Length == 1) return longest;

        foreach (var s in strs)
        {
            while (!s.StartsWith(longest))
            {
                // A more "clean" version would use longest[..^1] but the overhead introduced
                // makes it a lot slower for such a trivial task
                longest = longest.Substring(0, longest.Length - 1);
                if (longest.Length == 0) return longest;
            }
        }

        return longest;
    }
}
