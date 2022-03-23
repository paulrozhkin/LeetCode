using LeetCode.Models;
using Xunit;

namespace LeetCode.Tests.Utils
{
    internal static class AssertHelper
    {
        public static void AssertLinkList(int[] expected, ListNode actual)
        {
            Assert.NotNull(actual);
            Assert.NotNull(expected);
            Assert.True(expected.Length > 0);

            var current = actual;
            foreach (var value in expected)
            {
                Assert.NotNull(current);
                Assert.Equal(value, current.val);
                current = current.next;
            }

            Assert.Null(current);
        }
    }
}
