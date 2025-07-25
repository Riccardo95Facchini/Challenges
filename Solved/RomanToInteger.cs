namespace Problems.Solved;

public class RomanToInteger
{
    // https://leetcode.com/problems/roman-to-integer/description/
    public int RomanToInt(string s)
    {
        return Helper(s, 0, 0, 1001);
    }

    private int Helper(string s, int index, int total, int last)
    {
        if (index == s.Length) return total;

        var value = s[index] switch
        {
            'M' => 1000,
            'D' => 500,
            'C' => 100,
            'L' => 50,
            'X' => 10,
            'V' => 5,
            'I' => 1,
            _ => 0
        };

        // Since we added the value before, we have to remove it twice now
        if (value > last) return Helper(s, index + 1, total + value - last - last, value);

        return Helper(s, index + 1, total + value, value);
    }
}
