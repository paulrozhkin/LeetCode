using LeetCode._201_250;
using LeetCode.Tests.Utils;
using Xunit;

namespace LeetCode.Tests._201_250
{
    public class _206_ReverseLinkedList_Test
    {
        [Fact]
        public void ReverseListTest()
        {
            var head = Generator.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _206_ReverseLinkedList();
            var newHead = solution.ReverseList(head);
            AssertHelper.AssertLinkList(new int[] { 5, 4, 3, 2, 1 }, newHead);
        }
    }
}
