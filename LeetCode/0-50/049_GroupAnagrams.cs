using System.Collections.Generic;
using System.Linq;

namespace LeetCode._0_50
{
    public class _049_GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            return strs
                .GroupBy(str => new string(str.OrderBy(ch => ch).ToArray()))
                .Select(x => (IList<string>) x.ToList())
                .ToList();
        }
    }
}