namespace Problems.Solved;

public class IntegerToRoman
{
    // https://leetcode.com/problems/integer-to-roman/description/
    /*
    I => 1
    V => 5
    X => 10
    L => 50
    C => 100
    D => 500
    M => 1000
    Only powers of 10 (I, X, C, M) can be consecutives, i.e. 49 is not IL but it's XLXI
     */

    public string IntToRoman(int num)
    {
        // There must be a cleaner solution, but I can't find it
        // Due to the power of 10 constraint we have to "fake" having other symbols, such as: 900, 400, 90, 40 and 9 and 4 => CM, CD, XC, XL, IX, IV
        return num switch
        {
            >= 1000 => "M" + IntToRoman(num - 1000),
            >= 900 => "CM" + IntToRoman(num - 900),
            >= 500 => "D" + IntToRoman(num - 500),
            >= 400 => "CD" + IntToRoman(num - 400),
            >= 100 => "C" + IntToRoman(num - 100),
            >= 90 => "XC" + IntToRoman(num - 90),
            >= 50 => "L" + IntToRoman(num - 50),
            >= 40 => "XL" + IntToRoman(num - 40),
            >= 10 => "X" + IntToRoman(num - 10),
            >= 9 => "IX" + IntToRoman(num - 9),
            >= 5 => "V" + IntToRoman(num - 5),
            >= 4 => "IV" + IntToRoman(num - 4),
            >= 1 => "I" + IntToRoman(num - 1),
            _ => ""
        };
    }
}
