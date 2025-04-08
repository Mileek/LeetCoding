using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example 1:

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
 */

namespace LeetCodes
{
    public class AddTwoNumbersClass
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 != null || l2 != null)
            {
                int value;
                if (l1 == null)
                {
                    value = l2.val % 10;
                    if (l2.val != 0 && value == 0)
                    {
                        if (l2.next == null)
                        {
                            l2.next = new ListNode(l2.val / 10);
                        }
                        else
                        {
                            l2.next.val++;
                        }
                    }
                }
                else if (l2 == null)
                {
                    value = l1.val % 10;
                    if (l1.val != 0 && value == 0)
                    {
                        if (l1.next == null)
                        {
                            l1.next = new ListNode(l1.val / 10);
                        }
                        else
                        {
                            l1.next.val++;
                        }
                    }
                }
                else
                {
                    value = (l1.val + l2.val) % 10;
                    if (l1.val + l2.val >= 10)
                    {
                        if (l1.next == null && l2.next == null)
                        {
                            l1.next = new ListNode((l1.val + l2.val) / 10);
                        }
                        else if (l1.next != null)
                        {
                            l1.next.val++;
                        }
                        else if (l2.next != null)
                        {
                            l2.next.val++;
                        }
                    }
                }

                return new ListNode(value, AddTwoNumbers(l1?.next, l2?.next));
            }

            return null;
        }

        public void Run()
        {
            ////OK
            //var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            //var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            //OK
            //var l1 = new ListNode(0);
            //var l2 = new ListNode(0);
            //OK
            //var l1 = new ListNode(5);
            //var l2 = new ListNode(5);
            //OK
            //var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            //var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            //OK
            //var l1 = new ListNode(2, new ListNode(4, new ListNode(9)));
            //var l2 = new ListNode(5, new ListNode(6, new ListNode(4, new ListNode(9))));
            //
            var l1 = new ListNode(8, new ListNode(3, new ListNode(2, new ListNode(7, new ListNode(4, new ListNode(5, new ListNode(7, new ListNode(9, new ListNode(8, new ListNode(1))))))))));
            var l2 = new ListNode(2, new ListNode(6, new ListNode(7, new ListNode(2, new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(0, new ListNode(1, new ListNode(8))))))))));

            var result = AddTwoNumbers(l1, l2);

            Console.WriteLine();
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
}