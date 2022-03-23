using LeetCode._0_50;
using LeetCode.Tests.Utils;
using Xunit;

namespace LeetCode.Tests._0_50
{
    public class _002_AddTwoNumbers_Test
    {
        [Fact]
        public void AddTwoNumbersTest_General()
        {
            var link = Generator.GenerateList(new int[] { 2, 4, 3 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link, link);

            AssertHelper.AssertLinkList(new int[] { 4, 8, 6 }, result);
        }

        [Fact]
        public void AddTwoNumbersTest_General_2()
        {
            var link = Generator.GenerateList(new int[] { 0 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link, link);

            AssertHelper.AssertLinkList(new int[] { 0 }, result);
        }

        [Fact]
        public void AddTwoNumbersTest_HasCarry()
        {
            var link1 = Generator.GenerateList(new int[] { 2, 4, 3 });
            var link2 = Generator.GenerateList(new int[] { 5, 6, 4 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 7, 0, 8 }, result);
        }

        [Fact]
        public void AddTwoNumbersTest_HasMultipleCarry()
        {
            var link1 = Generator.GenerateList(new int[] { 1 });
            var link2 = Generator.GenerateList(new int[] { 9, 9 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 0, 0, 1 }, result);
        }

        [Fact]
        public void AddTwoNumbersTest_FirstNumCarry()
        {
            var link1 = Generator.GenerateList(new int[] { 3, 4, 4 });
            var link2 = Generator.GenerateList(new int[] { 3, 4, 6 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 6, 8, 0, 1 }, result);
        }

        [Fact]
        public void AddTwoNumbersTest_L1Longer()
        {
            var link1 = Generator.GenerateList(new int[] { 2, 4, 3, 1 });
            var link2 = Generator.GenerateList(new int[] { 5, 6, 4 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 7, 0, 8, 1 }, result);
        }

        [Fact]
        public void AddTwoNumbersTest_L1Longer_2()
        {
            var link1 = Generator.GenerateList(new int[] { 1, 8 });
            var link2 = Generator.GenerateList(new int[] { 0 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }

        [Fact]
        public void AddTwoNumbersTest_L1Empty()
        {
            var link1 = Generator.GenerateList(null);
            var link2 = Generator.GenerateList(new int[] { 1, 8 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }

        [Fact]
        public void AddTwoNumbersTest_L2Longer()
        {
            var link1 = Generator.GenerateList(new int[] { 2, 4, 3 });
            var link2 = Generator.GenerateList(new int[] { 5, 6, 4, 3 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 7, 0, 8, 3 }, result);
        }

        [Fact]
        public void AddTwoNumbersTest_L2Longer_2()
        {
            var link1 = Generator.GenerateList(new int[] { 0 });
            var link2 = Generator.GenerateList(new int[] { 1, 8 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }

        [Fact]
        public void AddTwoNumbersTest_L2Empty()
        {
            var link1 = Generator.GenerateList(new int[] { 1, 8 });
            var link2 = Generator.GenerateList(null);

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList(new int[] { 1, 8 }, result);
        }
    }
}
