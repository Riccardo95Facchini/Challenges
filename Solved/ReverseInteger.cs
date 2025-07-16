namespace Problems.Solved;

public class ReverseInteger
{

    // https://leetcode.com/problems/reverse-integer/description/

    public int Reverse(int x)
    {
        bool isNegative = false;

        if (x < 0)
        {
            isNegative = true;
            x *= -1;
        }

        int result = 0;
        int check = isNegative ? (int.MinValue / 10) * (-1) : int.MaxValue / 10;
        int checkRemaining = isNegative ? (int.MinValue % 10) * (-1) : int.MaxValue % 10;
        while (x > 0)
        {
            int toRemove = (x % 10);

            if (result > check || (result == check && toRemove >= checkRemaining))
                return 0;

            result = (result * 10) + toRemove;
            x = (x - toRemove) / 10;
        }

        return isNegative ? result * -1 : result;
    }
}
