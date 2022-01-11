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
    
    public int SumRootToLeaf(TreeNode root) {        
        return Traverse(root, 0);
    }
    
    private int Traverse(TreeNode root, int number)
    {
        if (root == null) { return 0; }
              
        number <<= 1; 
        number += root.val;
        
        if (root.left == null && root.right == null) {  return number; }
        
        return Traverse(root.left, number) + Traverse(root.right, number);
    }
}