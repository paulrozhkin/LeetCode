using LeetCode._151_200;
using Xunit;

namespace LeetCode.Tests._151_200
{
    public class _152_MaximumProductSubarray_Test
    {
        [Fact]
        public void MaxProductTest_1()
        {
            var solution = new _152_MaximumProductSubarray();
            var result = solution.MaxProduct(new int[] { 2, 3, -2, 4 });
            Assert.Equal(6, result);
        }

        [Fact]
        public void MaxProductTest_2()
        {
            var solution = new _152_MaximumProductSubarray();
            var result = solution.MaxProduct(new int[] { -2, 0, -1 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void MaxProductTest_3()
        {
            var solution = new _152_MaximumProductSubarray();
            var result = solution.MaxProduct(new int[] { 1 });
            Assert.Equal(1, result);
        }

        [Fact]
        public void MaxProductTest_4()
        {
            var solution = new _152_MaximumProductSubarray();
            var result = solution.MaxProduct(new int[] { });
            Assert.Equal(0, result);
        }
    }
}
