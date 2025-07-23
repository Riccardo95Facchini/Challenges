namespace Problems.Solved;

public class RegularExpressionMatching
{
    // https://leetcode.com/problems/regular-expression-matching/description/

    public bool Run(string s, string p)
    {
        return Run(s, p, 0, 0);
    }

    private bool Run(string s, string p, int i, int j)
    {
        if (j >= p.Length) return i == s.Length; // If the regex is exausted check if we finished checking the string

        // We might end up having a longer regex than string or due to an '*' we might iterate too much,
        // so when checking a match we should also check if we are still inside with the index
        bool isMatch = (i < s.Length) && (p[j] == s[i] || p[j] == '.');

        // If there's a '*' we have two options: either it matches n times, or 0 times, so we put them in OR.
        // We can't call only one bacause in cases such as 'aaa' 'a*a' we have to match the first 'a' twice and
        // then match the second one for the third in the original string: this can only be
        // generalized by exploring both paths until the end, i.e. using OR
        if (j + 1 < p.Length && p[j + 1] == '*')
            return (isMatch && Run(s, p, i + 1, j)) || Run(s, p, i, j + 2);
        else
            return isMatch && Run(s, p, i + 1, j + 1); // If we do not have a '*' we just return the match result and increment the indexes
    }
}
