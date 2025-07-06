using Problems.Solved;

namespace Problems;

class Program
{
    static void Main(string[] args)
    {
        LengthOfLongestSubstring l = new();
        System.Console.WriteLine(l.Run("ohvhjdml"));
        System.Console.WriteLine(l.Run("dvdf"));
        System.Console.WriteLine(l.Run("abcabcbb"));
        System.Console.WriteLine(l.Run("bbbbb"));
        System.Console.WriteLine(l.Run("pwwkew"));
        System.Console.WriteLine(l.Run(""));
        System.Console.WriteLine(l.Run(" "));
        System.Console.WriteLine(l.Run("a"));
    }
}
