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
    public ListNode MergeKLists(ListNode[] lists) {
        
        if (lists == null || lists.Length == 0)
            return null;
        
        if (lists.Length == 1)
            return lists[0];

        var dict = new Dictionary<int,List<ListNode>>();

        foreach (var list in lists)
        {
            var cur = list;
            while (cur != null)
            {
                if (dict.ContainsKey(cur.val))
                    dict[cur.val].Add(cur);
                else
                    dict.Add(cur.val, new List<ListNode>() {cur});

                cur = cur.next;
            }
        }

        var sorted = dict.OrderBy(d => d.Key).ToArray();
        ListNode head = null, curNode = null;
        
        foreach (var nodes in sorted)
        {
            foreach (var node in nodes.Value)
            {
                if (head == null)
                {
                    head = node;
                    curNode = head;
                }
                else
                {
                    curNode.next = node;
                    curNode = curNode.next;
                }
            }
        }

        if (curNode != null) 
            curNode.next = null;

        return head;
    }
}