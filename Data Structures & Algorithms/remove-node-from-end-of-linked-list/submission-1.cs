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

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        /*** BRUTE FORCE
         * Add all nodes into an array
         * the index of the node to be removed k is sz - n
         * if k == 0, move head to the next node
         * else, remove node at k
         */

        // var nodeArr = new List<ListNode>();
        //
        // var iterator = head;
        // while (iterator != null)
        // {
        //     nodeArr.Add(iterator);
        //     iterator = iterator.next;
        // }
        //
        // var k = nodeArr.Count - n;
        // if (k == 0)
        // {
        //     head = head.next;
        // }
        // else
        // {
        //     var prevNode = nodeArr[k - 1];
        //     var newNextNode = k + 1 < nodeArr.Count ? nodeArr[k + 1] : null;
        //     prevNode.next = newNextNode;
        // }

        /***
         * Do one pass to get the length of the list of nodes
         * Do another pass to remove the nth node
         * THIS APPROACH USES O(1) Space unlike the brute force approach
         */
        var listSize = 0;
        var iterator = head;
        while (iterator != null)
        {
            listSize++;
            iterator = iterator.next;
        }

        var k = listSize - n;
        iterator = head;
        if (k == 0)
        {
            head = head.next;
        }
        else
        {
            var i = 0;
            while (i < listSize)
            {
                if (i == k - 1)
                {
                    var prevNode = iterator;
                    var newNextNode = k + 1 < listSize ? iterator.next.next : null;
                    prevNode.next = newNextNode;
                    break;
                }

                iterator = iterator.next;
                i += 1;
            }
        }


        return head;
    }
}