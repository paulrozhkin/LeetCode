using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._000_050
{
    public class _006_ZigzagConversion_Test
    {
        [Fact]
        public void ConvertTest_General()
        {
            var input = "PAYPALISHIRING";

            var solution = new _006_ZigzagConversion();

            var result = solution.Convert(input, 3);
            Assert.Equal("PAHNAPLSIIGYIR", result);

            result = solution.Convert(input, 4);
            Assert.Equal("PINALSIGYAHRPI", result);

            result = solution.Convert(input, 5);
            Assert.Equal("PHASIYIRPLIGAN", result);
        }

        [Fact]
        public void ConvertTest_RowNumberEqualOne()
        {
            var input = "PAYPALISHIRING";

            var solution = new _006_ZigzagConversion();

            var result = solution.Convert(input, 1);
            Assert.Equal(input, result);
        }

        [Fact]
        public void ConvertTest_RowNumberEqualZero()
        {
            var input = "PAYPALISHIRING";

            var solution = new _006_ZigzagConversion();

            var result = solution.Convert(input, 0);
            Assert.Equal(input, result);
        }

        [Fact]
        public void ConvertTest_EmptyString()
        {
            var input = string.Empty;

            var solution = new _006_ZigzagConversion();

            var result = solution.Convert(input, 0);
            Assert.Equal(input, result);
        }
    }
}