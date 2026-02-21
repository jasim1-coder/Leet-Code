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
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> numbers = new List<int>();
        PreOrder(root,numbers);
        return numbers;
    }
     private void PreOrder(TreeNode root, IList<int> numbers){
            if(root == null) return;
            numbers.Add(root.val);
            PreOrder(root.left,numbers);
            PreOrder(root.right,numbers);
        } 
}