using System;

namespace Plus_One_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(9);
            head.next = new ListNode(9);
            head.next.next = null;
            ListNode result = PlusOne(head);
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        static ListNode PlusOne(ListNode head)
        {
            ListNode reversed = Reverse(head);
            ListNode temp = reversed;
            while (reversed != null) 
            {
                if(reversed.val +1 <= 9)
                {
                    reversed.val += 1;
                    break;
                }
                else
                {
                    reversed.val = 0;
                    if(reversed.next == null)
                    {
                        reversed.next = new ListNode(1);
                        break;
                    }
                    reversed = reversed.next;
                }
            }

            ListNode original = Reverse(temp);
            return original;
        }

        static ListNode Reverse(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode current = head;
            ListNode next = current.next;
            while (next != null)
            {
                ListNode t = next.next;
                next.next = current;
                current = next;
                next = t;
            }

            head.next = null;
            return current;
        }
    }
}
