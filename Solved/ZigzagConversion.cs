namespace Problems.Solved;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (s.Length <= 1 || numRows <= 1)
            return s;

        int row = 0;
        // Here using an array of strings is faster than using an array of StringBuilders 
        // due to the length of the test strings used by LeetCode
        string[] rows = new string[numRows];
        rows.Initialize();

        bool isGoingDown = false;

        for (int i = 0; i < s.Length; i++)
        {
            rows[row] += (s[i]);

            if (row == 0 || row == numRows - 1)
                isGoingDown = !isGoingDown;

            row = isGoingDown ? row + 1 : row - 1;
        }

        return string.Join("", rows);
    }
}
