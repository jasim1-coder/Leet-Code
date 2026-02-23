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
    public IList<int> PostorderTraversal(TreeNode root) {
        var Store = new List<int>();
        PostOrder(Store,root);
        return Store;
    }

    static void PostOrder(IList<int> store, TreeNode root){
        if(root == null)return ;

        PostOrder(store,root.left);
        PostOrder(store,root.right);
        store.Add(root.val);
    }
}