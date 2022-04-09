using System.Collections.Generic;
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

        public static void AssertList<T>(T[] expected, IList<T> actual)
        {
            Assert.Equal(expected.Length, actual.Count);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        public static void AssertList<T>(IList<IList<T>> expected, IList<IList<T>> actual)
        {
            Assert.Equal(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i].Count, actual[i].Count);
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.Equal(expected[i][j], actual[i][j]);
                }
            }
        }
    }
}