using Problems.Solved;

namespace Problems;

class Program
{
    static void Main(string[] args)
    {
        FindMedianSortedArrays a = new();
        System.Console.WriteLine(a.RunBinarySearch([23, 26, 31, 35], [3, 5, 7, 9, 11, 16]));
        //System.Console.WriteLine(a.RunBinarySearch([1, 2], [3, 4]));
    }
}
