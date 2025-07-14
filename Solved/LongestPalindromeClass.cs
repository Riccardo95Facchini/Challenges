namespace Problems.Solved;


/* Solving this challenge in O(n) requires implementing the ad hoc Manacher's Algorithm,
 therefore a simpler O(n2) is used to avoid replicating a single use case algo
 that's been specifically studied for this case

Given a string s, return the longest palindromic substring in s.

Example 1:
Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.

Example 2:
Input: s = "cbbd"
Output: "bb"
*/

public class LongestPalindromeClass
{
    public string LongestPalindrome(string s)
    {
        if (s.Length <= 1)
            return s;

        string longest = string.Empty;

        // One pass is O(n)
        for (int center = 0; center < s.Length; center++)
        {
            // another pass for odd ones is at most O(n/2) -> O(n)
            // GetLongestPalindrome(s, center, center, ref longest);

            // for even lengths (not of s but of palindromes) we "fake"
            // being in the middle of two letters by shifting the right boundry one to the right.
            // another pass for oddeven ones is at most O(n/2) -> O(n)
            GetLongestPalindrome(s, center, center + 1, ref longest);
        }

        // total complexity is O(n * (n/2 + n/2)) -> remove constants -> O(n2)

        return longest;
    }

    private static void GetLongestPalindrome(string s, int left, int right, ref string longest)
    {
        // Check if we are inside the boundries
        while (left >= 0 && right < s.Length)
        {
            // if we are pointing at two equal chars we are looking at a palindrom
            if (s[left] == s[right])
            {
                int palindromeLen = right - left + 1;
                if (palindromeLen > longest.Length) // we got a new longest!
                    longest = s.Substring(left, palindromeLen);
            }
            else // else we can quit with what we have
                return;

            left--;
            right++;
        }
    }
}
