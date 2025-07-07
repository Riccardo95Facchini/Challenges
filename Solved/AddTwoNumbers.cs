namespace Problems.Solved;

public class AddTwoNumbers
{
    /*
     https://leetcode.com/problems/add-two-numbers/description/
     You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
     You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
     */

    public ListNode Run(ListNode l1, ListNode l2)
    {
        ListNode startNode = new();
        ListNode iterationNode = startNode;
        int carry = 0;

        while (l1 != null || l2 != null || carry == 1)
        {
            int sum = l1 is null ? 0 : l1.val;
            sum += l2 is null ? 0 : l2.val;
            sum += carry;

            carry = sum / 10;
            ListNode newNode = new(sum % 10);
            iterationNode.next = newNode;
            iterationNode = iterationNode.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        return startNode.next;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
