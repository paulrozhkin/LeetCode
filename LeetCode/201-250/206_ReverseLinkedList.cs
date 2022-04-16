using LeetCode.Models;

namespace LeetCode._201_250
{
    public class _206_ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            return ReverseListRecursive(head);

            ListNode ReverseListRecursive(ListNode headInner)
            {
                if (headInner?.next == null)
                    return headInner;

                var rest = ReverseListRecursive(headInner.next);
                headInner.next.next = headInner;

                headInner.next = null;
                return rest;
            }
        }


        /*
        /// <summary>
        /// Time: O(N)
        /// Space: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            ListNode prevNode = null;
            ListNode currentNode = head;

            while (currentNode != null)
            {
                var nextNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }

            return prevNode;
        }

        /// <summary>
        /// Time: O(N)
        /// Space: O(N)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            if (head.next == null)
            {
                return head;
            }

            var references = new List<ListNode>();
            var item = head;
            while (item != null)
            {
                references.Add(item);
                item = item.next;
            }

            for (var i = references.Count - 1; i > 0; i--)
            {
                references[i].next = references[i - 1];
            }

            head.next = null;

            return references[^1];
        }
        */
    }
}