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
    public IList<int> RightSideView(TreeNode root) {
        
        var result = new List<int>();
        
        if(root == null) return result;
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        int level = 0;
        
        q.Enqueue(root);
        
        while(q.Count != 0){
            level = q.Count;
            while(level != 0){
                TreeNode node = q.Dequeue();
                
                if(node.left != null){
                    q.Enqueue(node.left);
                }
                
                if(node.right != null){
                    q.Enqueue(node.right);
                }
                
                if(level == 1){
                    result.Add(node.val);
                }
                
                level --;
            
            }
        }
        return result;
    }
}