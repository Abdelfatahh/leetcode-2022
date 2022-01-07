/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {

    private ListNode h;
    private Random random;
    
    public Solution(ListNode head) {
        
        random = new Random();
        h = head; 
    }
    
    public int GetRandom() {

        ListNode curr = h;
        int res = curr.val;
        int cnt = 1;
        
        while(curr != null && curr.next != null)
        {      
            curr = curr.next;
            cnt++;
            
            // reservoir sampling
            // choose the i-th node with probability of 1/cnt
            if(random.Next(0,cnt) == 0)
                res = curr.val;
        }
        
        return res;           
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */