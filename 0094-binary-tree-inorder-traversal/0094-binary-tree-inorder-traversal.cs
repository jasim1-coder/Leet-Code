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
    public IList<int> InorderTraversal(TreeNode root) {
        var Store = new List<int>();
        InOrder(Store,root);
        return Store;
    }
    static void InOrder(List<int> Store,TreeNode root){
        if(root == null)return;
        InOrder(Store,root.left);
        Store.Add(root.val);
        InOrder(Store,root.right);
    }
}