using LeetCode._201_250;
using Xunit;

namespace LeetCode.Tests._201_250
{
    public class _238_ProductOfArrayExceptSelf_Test
    {
        [Fact]
        public void ProductExceptSelfTest_1()
        {
            var solution = new _238_ProductOfArrayExceptSelf();
            var result = solution.ProductExceptSelf(new int[] { 1, 2, 3, 4 });
            Assert.Equal(new int[] { 24, 12, 8, 6 }, result);
        }

        [Fact]
        public void ProductExceptSelfTest_2()
        {
            var solution = new _238_ProductOfArrayExceptSelf();
            var result = solution.ProductExceptSelf(new int[] { 0, 1, 2, 3, 4 });
            Assert.Equal(new int[] { 24, 0, 0, 0, 0 }, result);
        }

        [Fact]
        public void ProductExceptSelfTest_3()
        {
            var solution = new _238_ProductOfArrayExceptSelf();
            var result = solution.ProductExceptSelf(new int[] { 1, 2, 3, 4, 0, 0 });
            Assert.Equal(new int[] { 0, 0, 0, 0, 0, 0 }, result);
        }
    }
}
