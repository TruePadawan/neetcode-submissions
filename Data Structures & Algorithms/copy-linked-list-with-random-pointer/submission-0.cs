/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution
{
    public Node copyRandomList(Node head)
    {
        /**
         * Create a hashmap linking original nodes to their copies
         * Do one pass to create the copies and populate the hashmap
         * Do another pass to link the random pointer to the equivalent copied node
         */

        if (head == null) return null;

        var map = new Dictionary<Node, Node>();
        Node copyHead = new Node(head.val);
        var iterator = head;
        var copyIterator = copyHead;

        // Create copy
        while (iterator != null)
        {
            map.Add(iterator, copyIterator);

            copyIterator.val = iterator.val;

            iterator = iterator.next;
            if (iterator != null)
            {
                copyIterator.next = new Node(-1);
                copyIterator = copyIterator.next;
            }
        }

        iterator = head;
        copyIterator = copyHead;
        while (iterator != null)
        {
            var originalRandomNode = iterator.random;
            if (originalRandomNode != null)
            {
                copyIterator.random = map[originalRandomNode];
            }

            iterator = iterator.next;
            copyIterator = copyIterator.next;
        }

        return copyHead;
    }
}