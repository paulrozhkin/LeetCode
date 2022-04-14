using LeetCode.Models;

namespace LeetCode._101_150
{
    public class _141_LinkedListCycle
    {
        /// <summary>
        /// Floyd's tortoise and hare
        /// Space: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head)
        {
            var fast = head;
            var slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                {
                    return true;
                }
            }

            return false;
        }

        /*
        /// <summary>
        /// Space: O(N)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head)
        {
            var nodes = new List<ListNode>();
            while (head != null)
            {
                if (nodes.Contains(head))
                {   
                    return true;
                }

                nodes.Add(head);
                head = head.next;
            }

            return false;
        }
        */
    }
}
