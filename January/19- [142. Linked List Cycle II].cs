public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var list = new List<ListNode>();
        for(ListNode i = head; i != null && i.next != null; i = i.next) {
            if(!list.Contains(i))
                list.Add(i);
            else
                return i;
        }
        return null;
    }
}