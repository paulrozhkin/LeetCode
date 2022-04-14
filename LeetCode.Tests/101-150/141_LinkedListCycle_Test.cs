using LeetCode._101_150;
using LeetCode.Tests.Utils;
using Xunit;

namespace LeetCode.Tests._101_150
{
    public class _141_LinkedListCycle_Test
    {
        [Fact]
        public void HasCycle_1()
        {
            var root = Generator.GenerateList(new int[] { 3, 2, 0, -4 });
            root.next.next.next.next = root.next;

            var solution = new _141_LinkedListCycle();
            var result = solution.HasCycle(root);
            Assert.True(result);
        }

        [Fact]
        public void HasCycle_2()
        {
            var root = Generator.GenerateList(new int[] { 1, 2 });
            root.next.next = root;

            var solution = new _141_LinkedListCycle();
            var result = solution.HasCycle(root);
            Assert.True(result);
        }

        [Fact]
        public void HasCycle_3()
        {
            var root = Generator.GenerateList(new int[] { 1 });

            var solution = new _141_LinkedListCycle();
            var result = solution.HasCycle(root);
            Assert.False(result);
        }
    }
}
