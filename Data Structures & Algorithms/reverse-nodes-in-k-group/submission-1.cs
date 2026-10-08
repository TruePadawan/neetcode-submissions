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
    public ListNode ReverseKGroup(ListNode head, int k) {
        /**
         * Do a loop of iterations k
         * Once I've looped k times, I know i need to reverse those set of k nodes
         * But I'll need to link the new last node to the next possibly reversed set of k nodes
         * So after iterating k times and reversing those set of k nodes, recursively do for the next and return the head
         * Link the head to the next pointer recursively
         */

        ListNode? iterator = head;
        ListNode newHead = head;
        for (var i = 1; i <= k; ++i)
        {
            if (i == k)
            {
                // Reverse the next set of nodes
                var originalNext = iterator.next;
                var reversedNext = iterator.next is null ? null : ReverseKGroup(iterator.next, k);
                
                // Reverse this set of k nodes
                ListNode? formerNode = null;
                ListNode initialHead = head;
                while (head != originalNext)
                {
                    ListNode? originalNextNode = head.next;
                    head.next = formerNode;
                    formerNode = head;
                    head = originalNextNode;
                }

                initialHead.next = reversedNext;
                newHead = formerNode;
                break;
            }

            iterator = iterator.next;
            // If this set of nodes isn't up to k,  don't reverse them
            if (iterator == null) break;
        }

        return newHead;
    }
}