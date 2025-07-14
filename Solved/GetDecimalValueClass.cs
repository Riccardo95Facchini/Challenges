namespace Problems.Solved;

public class GetDecimalValueClass
{
    public int GetDecimalValue(ListNode head)
    {
        int result = 0;
        while (head != null)
        {
            result = result * 2 + head.val;
            head = head.next;
        }

        return result;
    }
}
