using LeetCode._201_250;
using Xunit;

namespace LeetCode.Tests._201_250
{
    public class _217_ContainsDuplicate_Test
    {
        [Fact]
        public void ContainsDuplicate_1()
        {
            var solution = new _217_ContainsDuplicate();
            var result = solution.ContainsDuplicate(new int[] { 1, 2, 3, 1 });
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicate_2()
        {
            var solution = new _217_ContainsDuplicate();
            var result = solution.ContainsDuplicate(new int[] { 1, 2, 3, 4 });
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicate_3()
        {
            var solution = new _217_ContainsDuplicate();
            var result = solution.ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
            Assert.True(result);
        }
    }
}
