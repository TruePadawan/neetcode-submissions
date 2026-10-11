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
    private bool balanced = true;
    
    public bool IsBalanced(TreeNode root) {
        Recursive(root);
        return balanced;
    }

    private int Recursive(TreeNode node) {
        if (node is null) return 0;
        if (node.left is null && node.right is null) return 1;

        var l = Recursive(node.left);
        var r = Recursive(node.right);

        if (Math.Abs(l - r) > 1) {
            balanced = false;
        }

        return 1 + Math.Max(l, r);
    }
}
