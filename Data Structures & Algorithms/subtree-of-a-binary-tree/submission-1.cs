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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root is null) return subRoot is null;

        if (root.val == subRoot.val && IsSameTree(root, subRoot)) return true;

        var l = IsSubtree(root.left, subRoot);
        var r = IsSubtree(root.right, subRoot);

        return l || r;
    }

    private bool IsSameTree(TreeNode p, TreeNode q) {
        if (p is null || q is null) return p == q;

        var l = IsSameTree(p.left, q.left);
        var r = IsSameTree(p.right, q.right);

        var same = p.val == q.val;
        
        return same && l && r;
    }
}
