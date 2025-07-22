namespace Problems.Solved;

public class PalindromeNumber
{
    // https://leetcode.com/problems/palindrome-number/description/
    // Given an integer x, return true if x is a palindrome, and false otherwise.

    public bool Run(int x)
    {
        if (x < 0)
            return false;

        int temp = x;
        int reversed = 0;

        while (temp != 0)
        {
            reversed = (reversed * 10) + temp % 10;
            temp /= 10;
        }

        return reversed == x;
    }
}
