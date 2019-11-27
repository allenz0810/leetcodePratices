using System;
namespace LeetCodePratices.question2
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class question2
    {

        /*2. Add Two Numbers
         *
         * You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

            You may assume the two numbers do not contain any leading zero, except the number 0 itself.

            Example:

            Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            Output: 7 -> 0 -> 8
            Explanation: 342 + 465 = 807.
         *
         */
        public question2()
        {
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(-1);
            var currentNode = result;
            int carryOver = 0;
            while (l1 != null || l2 != null)
            {
                var currentTotal = (l1?.val ?? 0) + (l2?.val ?? 0) + carryOver;
                carryOver = currentTotal >= 10 ? 1 : 0;
                currentNode.next = new ListNode(currentTotal % 10);
                currentNode = currentNode.next;
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            if (carryOver == 1)
            {
                currentNode.next = new ListNode(carryOver);
                currentNode = currentNode.next;
            }
            return result.next;
        }


    }
}
