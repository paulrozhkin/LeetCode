using LeetCode._151_200;
using Xunit;

namespace LeetCode.Tests._151_200
{
    public class _153_FindMinimumInRotatedSortedArray_Test
    {
        [Fact]
        public void FindMinTest_1()
        {
            var solution = new _153_FindMinimumInRotatedSortedArray();
            var result = solution.FindMin(new[] {3, 4, 5, 1, 2});
            Assert.Equal(1, result);
        }

        [Fact]
        public void FindMinTest_2()
        {
            var solution = new _153_FindMinimumInRotatedSortedArray();
            var result = solution.FindMin(new[] {4, 5, 6, 7, 0, 1, 2});
            Assert.Equal(0, result);
        }

        [Fact]
        public void FindMinTest_3()
        {
            var solution = new _153_FindMinimumInRotatedSortedArray();
            var result = solution.FindMin(new[] {11, 13, 15, 17});
            Assert.Equal(11, result);
        }
    }
}