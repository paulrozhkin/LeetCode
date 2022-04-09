using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._000_050
{
    public class _007_ReverseInteger_Test
    {
        [Fact]
        public void ReverseTest_Positive()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(1);
            Assert.Equal(1, result);

            result = solution.Reverse(123);
            Assert.Equal(321, result);

            result = solution.Reverse(321);
            Assert.Equal(123, result);
        }

        [Fact]
        public void ReverseTest_Negative()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(-1);
            Assert.Equal(-1, result);

            result = solution.Reverse(-123);
            Assert.Equal(-321, result);

            result = solution.Reverse(-321);
            Assert.Equal(-123, result);
        }

        [Fact]
        public void ReverseTest_EqualZero()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void ReverseTest_PositiveOverflow()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(1534236469);
            Assert.Equal(0, result);
        }

        [Fact]
        public void ReverseTest_NegativeOverflow()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(-1534236469);
            Assert.Equal(0, result);
        }
    }
}
