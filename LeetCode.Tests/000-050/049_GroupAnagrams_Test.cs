using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._0_50;
using LeetCode.Tests.Utils;
using Xunit;

namespace LeetCode.Tests._000_050
{
    public class _049_GroupAnagrams_Test
    {
        [Fact]
        public void GroupAnagramsTest()
        {
            var input = new string[] {"eat", "tea", "tan", "ate", "nat", "bat"};

            var solution = new _049_GroupAnagrams();
            var result = solution.GroupAnagrams(input);

            AssertHelper.AssertList(
                new List<IList<string>>()
                {
                    new List<string>() {"eat", "tea", "ate"},
                    new List<string>() {"tan", "nat"},
                    new List<string>() {"bat"}
                }, result);
        }

        [Fact]
        public void GroupAnagramsTest_Empty()
        {
            var input = new string[] { };

            var solution = new _049_GroupAnagrams();
            var result = solution.GroupAnagrams(input);

            Assert.Empty(result);
        }
    }
}