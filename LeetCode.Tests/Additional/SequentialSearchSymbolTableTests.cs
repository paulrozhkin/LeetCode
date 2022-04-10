using System;
using System.Collections.Generic;
using LeetCode.Additional;
using Xunit;

namespace LeetCode.Tests.Additional
{
    public class SequentialSearchSymbolTableTest
    {
        private readonly SequentialSearchSymbolTable<string, int> _st;

        public SequentialSearchSymbolTableTest()
        {
            _st = new SequentialSearchSymbolTable<string, int>();
        }

        [Fact]
        public void Count_PutSingleItem_ReturnsOne()
        {
            _st.Add("a", 1);

            Assert.Equal(1, _st.Count);
        }

        [Fact]
        public void Add_PassNullAsKey_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => _st.Add(null, 0));
        }

        [Fact]
        public void Remove_PassNullAsKey_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => _st.Remove(null));
        }

        [Fact]
        public void Ctor_PassNullAsComparer_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => { new SequentialSearchSymbolTable<string, int>(null); });
        }

        [Fact]
        public void Contains_PutSingeItem_ContainsThatItem()
        {
            _st.Add("a", 1);

            Assert.True(_st.Contains("a"));
            Assert.False(_st.Contains("b"));
        }


        [Fact]
        public void Get_PutSingleItem_ReturnsTrueAndValue()
        {
            _st.Add("a", 1);

            bool exists = _st.TryGet("a", out int result);

            Assert.Equal(1, result);
            Assert.True(exists);
        }

        [Fact]
        public void GetByInexistentKey_PutSingleItem_ReturnsFalseAndDefaultValue()
        {
            _st.Add("a", 1);

            bool exists = _st.TryGet("b", out int result);

            Assert.Equal(default(int), result);
            Assert.False(exists);
        }

        [Fact]
        public void UpdateValueByKey_ValueGetsRewritten()
        {
            _st.Add("a", 1);
            _st.Add("a", 2);

            _st.TryGet("a", out int result);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Remove_AddOneOrSeveralItems_CorrectState()
        {
            _st.Add("a", 1);
            Assert.False(_st.Remove("b"));

            _st.Remove("a");
            Assert.Equal(0, _st.Count);

            _st.Add("a", 1);
            _st.Add("b", 2);

            _st.Remove("a");
            Assert.Equal(1, _st.Count);

            _st.TryGet("b", out int result);
            Assert.Equal(2, result);

            _st.Add("a", 1);
            _st.Remove("a");

            Assert.Equal(1, _st.Count);

            _st.TryGet("b", out result);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Keys_SeveralKeys_CorrectSequence()
        {
            _st.Add("a", 1);
            _st.Add("b", 2);
            _st.Add("c", 3);

            var expected = new List<string> {"c", "b", "a"};
            Assert.Equal(expected, _st.Keys());
        }
    }
}