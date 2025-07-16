namespace Problems.Solved;

public partial class StringToIntegerAtoi
{
    // https://leetcode.com/problems/string-to-integer-atoi/

    public int MyAtoi(string s)
    {
        int i = 0;

        for (; i < s.Length && s[i] == ' '; i++) { }

        if (i >= s.Length)
            return 0;

        bool isNegative = false;
        if (s[i] == '-')
        {
            isNegative = true;
            i++;
        }
        else if (s[i] == '+')
            i++;

        long result = 0;
        for (; i < s.Length; i++)
        {
            string c = s[i].ToString();

            if (s[i] - '0' < 0 || s[i] - '9' > 0)
                break;

            result = (result * 10) + s[i] - '0';

            if (isNegative && result * -1 <= int.MinValue) return int.MinValue;
            else if (!isNegative && result >= int.MaxValue) return int.MaxValue;
        }

        return (int)result * (isNegative ? -1 : 1);
    }
}
