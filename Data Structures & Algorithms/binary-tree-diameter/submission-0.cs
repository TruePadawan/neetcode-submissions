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
    private int diameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        Recursive(root);
        return diameter;
    }

    private int Recursive(TreeNode node) {
        if (node is null) return 0;
        if (node.left is null && node.right is null) return 1;

        var l = Recursive(node.left);
        var r = Recursive(node.right);
        diameter = Math.Max(diameter, l + r);

        return 1 + Math.Max(l, r);
    }
}
