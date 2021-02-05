/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    List<ListNode> list = new List<ListNode>();
    
    public bool HasCycle(ListNode head) {
        if(head == null) return false;
        if(head.next != null){
            if(this.list.Contains(head.next)){
                return true;
            }
            this.list.Add(head);
            return HasCycle(head.next);
        }
        
        return false;
    }
}