using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._201_250
{
    public class _217_ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hashSet = new HashSet<int>();
            foreach (var num in nums)
            {
                if (hashSet.Contains(num))
                    return true;

                hashSet.Add(num);
            }

            return false;
        }
}
}
