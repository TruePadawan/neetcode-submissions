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
    public int MaxDepth(TreeNode root) {
        return DFS(root, 1);
    }

    private int DFS(TreeNode root, int depth) {
        if (root is null) return depth - 1;

        var l = DFS(root.left, depth + 1);
        var r = DFS(root.right, depth + 1);

        return Math.Max(l, r);
    }
}
