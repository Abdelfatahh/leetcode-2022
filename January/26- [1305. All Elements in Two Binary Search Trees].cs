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
    IList<int> L = new List<int>();

    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {

        if(root1!=null) getlist(root1);
        if(root2!=null) getlist(root2);
        L = L.OrderBy(a=>a).ToList();
        return L;

    }

    private void getlist(TreeNode root)
    {
        if(root!=null)
        {
        L.Add(root.val);
        if(root.left!=null)  getlist(root.left);
        if(root.right!=null) getlist(root.right);
        }
    }
}