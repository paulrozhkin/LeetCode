using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._000_050
{
    public class _008_StringToInteger_Test
    {
        [Fact]
        public void MyAtoiTest_Positive()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("123");
            Assert.Equal(123, result);

            result = solution.MyAtoi("+123");
            Assert.Equal(123, result);
        }

        [Fact]
        public void MyAtoiTest_Nagative()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("-123");
            Assert.Equal(-123, result);
        }

        [Fact]
        public void MyAtoiTest_Zero()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("0");
            Assert.Equal(0, result);
        }

        [Fact]
        public void MyAtoiTest_PositiveZero()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("+0");
            Assert.Equal(0, result);
        }

        [Fact]
        public void MyAtoiTest_NagativeZero()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("-0");
            Assert.Equal(0, result);
        }

        [Fact]
        public void MyAtoiTest_Boundary()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("2147483647");
            Assert.Equal(2147483647, result);

            result = solution.MyAtoi("2147483646");
            Assert.Equal(2147483646, result);

            result = solution.MyAtoi("-2147483648");
            Assert.Equal(-2147483648, result);

            result = solution.MyAtoi("-2147483647");
            Assert.Equal(-2147483647, result);
        }

        [Fact]
        public void MyAtoiTest_PositiveOverflow()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("2147483648");
            Assert.Equal(int.MaxValue, result);

            result = solution.MyAtoi("2247483647");
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void MyAtoiTest_NagativeOverflow()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("-2147483649");
            Assert.Equal(int.MinValue, result);

            result = solution.MyAtoi("-2247483648");
            Assert.Equal(int.MinValue, result);
        }

        [Fact]
        public void MyAtoiTest_WhiteSpaceInFrontOfInput()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("   123");
            Assert.Equal(123, result);

            result = solution.MyAtoi("   -123");
            Assert.Equal(-123, result);
        }

        [Fact]
        public void MyAtoiTest_EmptyString()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("");
            Assert.Equal(0, result);

            result = solution.MyAtoi("   ");
            Assert.Equal(0, result);
        }

        [Fact]
        public void MyAtoiTest_InvalidInput()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("abc");
            Assert.Equal(0, result);
        }

        [Fact]
        public void MyAtoiTest_MixInput()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("123abc");
            Assert.Equal(123, result);

            result = solution.MyAtoi("-123abc");
            Assert.Equal(-123, result);
        }

        [Fact]
        public void MyAtoiTest_MixInputWithOverflow()
        {
            var solution = new _008_StringToInteger();

            var result = solution.MyAtoi("  2147483648abc");
            Assert.Equal(int.MaxValue, result);

            result = solution.MyAtoi("  2247483647abc");
            Assert.Equal(int.MaxValue, result);

            result = solution.MyAtoi("  -2147483649abc");
            Assert.Equal(int.MinValue, result);

            result = solution.MyAtoi("  -2247483648abc");
            Assert.Equal(int.MinValue, result);
        }
    }
}
