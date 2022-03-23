using LeetCode.Models;

namespace LeetCode._0_50
{
    public class _002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var carry = 0;
            ListNode dummyHead = new ListNode(0);
            ListNode resultedNode = dummyHead;

            while (l1 != null || l2 != null || carry == 1)
            {
                var l1Val = l1?.val ?? 0;
                var l2Val = l2?.val ?? 0;
                var sum = l1Val + l2Val + carry;
                var result = sum % 10;
                carry = sum / 10;

                var newNode = new ListNode(result);

                resultedNode.next = newNode;

                resultedNode = newNode;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            return dummyHead.next;
        }
    }
}