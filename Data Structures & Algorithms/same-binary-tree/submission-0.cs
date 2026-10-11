/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p is null || q is null) return p == q;

        var l = IsSameTree(p.left, q.left);
        var r = IsSameTree(p.right, q.right);

        var same = p.val == q.val;
        
        return same && l && r;
    }
}
