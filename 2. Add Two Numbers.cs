// Same as Java version
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode dummy=new ListNode(0);
        ListNode cur=dummy;
        int carry=0;
        int total=0;
        int v1=0;
        int v2=0;
        

        while (l1!=null || l2 !=null || carry!=0){
            if (l1 !=null){
                v1=l1.val;
            } else {v1=0;}
            if (l2 !=null){
                v2=l2.val;
            } else {v2=0;}

            total=v1+v2+carry;
            int sums=total%10; //取餘數
            carry=total/10; //取商數

            cur.next=new ListNode(sums);
            cur=cur.next;
            
            if(l1 !=null){
                l1=l1.next;
            }
            if(l2 !=null){
                l2=l2.next;
            }
        }return dummy.next;

    }
}
