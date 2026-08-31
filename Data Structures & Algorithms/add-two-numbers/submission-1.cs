/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    var carry = 0;
    var result = new ListNode(-1);
    var resultIterator = new ListNode();

    var up = l1;
    var down = l2;

    while (up != null || down != null)
    {
        var currentNode = new ListNode();

        var left = up?.val ?? 0;
        var right = down?.val ?? 0;
        var currSum = left + right + carry;
        var nodeVal = currSum;
        if (currSum > 9)
        {
            carry = 1;
            nodeVal = currSum - 10;
        }
        else
        {
            carry = 0;
        }

        currentNode.val = nodeVal;
        if (result.val == -1)
        {
            result = currentNode;
            resultIterator = result;
        }
        else
        {
            resultIterator.next = currentNode;
            resultIterator = resultIterator.next;
        }

        up = up?.next;
        down = down?.next;
    }

    if (carry != 0)
    {
        resultIterator.next = new ListNode(carry);
    }

    return result;
}


}
