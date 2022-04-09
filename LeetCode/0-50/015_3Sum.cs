using System;
using System.Collections.Generic;

namespace LeetCode._0_50
{
    public class _015_3Sum
    {
        /// <summary>
        /// O(N^2)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 3)
            {
                return result;
            }

            Array.Sort(nums);

            for (var num1Idx = 0; num1Idx < nums.Length; num1Idx++)
            {
                if (num1Idx > 0 && nums[num1Idx] == nums[num1Idx - 1])
                    continue;

                var num2Idx = num1Idx + 1;
                var num3Idx = nums.Length - 1;

                while (num3Idx > num2Idx)
                {
                    var sumOfThree = nums[num1Idx] + nums[num2Idx] + nums[num3Idx];
                    if (sumOfThree == 0)
                    {
                        result.Add(new List<int>() {nums[num1Idx], nums[num2Idx], nums[num3Idx]});

                        num3Idx--;
                        while (num3Idx > num2Idx && nums[num3Idx] == nums[num3Idx + 1])
                        {
                            num3Idx--;
                        }
                    }
                    else if (sumOfThree > 0)
                    {
                        num3Idx--;
                    }
                    else
                    {
                        num2Idx++;
                    }
                }
            }

            return result;
        }

        /*

        /// <summary>
        /// O(N^3)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var resultedList = new List<IList<int>>();

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    for (var k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var newArray = new List<int> {nums[i], nums[j], nums[k]};
                            newArray.Sort();
                            if (resultedList.All(x => !x.SequenceEqual(newArray)))
                            {
                                resultedList.Add(newArray);
                            }
                        }
                    }
                }
            }

            return resultedList;
        }
        */
    }
}