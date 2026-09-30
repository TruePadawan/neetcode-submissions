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
    public void ReorderList(ListNode head)
    {
        /***
         * Add all nodes sequentially into an array
         * Using two pointers, point the left node to the right node
         * Keep track of the previous right node, ensure it is linked to the next reordered left node
         * If left node == right node, link the node to the prev right node
         * Do this while left index <= right index
         * At the last step, ensure the right node is linked to no node to prevent cycles
         */

        var nodeArr = new List<ListNode>();

        var iterator = head;
        while (iterator != null)
        {
            nodeArr.Add(iterator);
            iterator = iterator.next;
        }

        var leftIndex = 0;
        var rightIndex = nodeArr.Count - 1;
        ListNode? prevRightNode = null;

        while (leftIndex <= rightIndex)
        {
            var leftNode = nodeArr[leftIndex];
            var rightNode = nodeArr[rightIndex];

            if (leftIndex == rightIndex && prevRightNode != null)
            {
                prevRightNode.next = leftNode;
            }
            else
            {
                leftNode.next = rightNode;

                if (prevRightNode != null)
                {
                    prevRightNode.next = leftNode;
                }

                prevRightNode = rightNode;
            }

            leftIndex++;
            rightIndex--;

            // Prevent cycles
            if (leftIndex > rightIndex)
            {
                rightNode.next = null;
            }
        }
    }
}