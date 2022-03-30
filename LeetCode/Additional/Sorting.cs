using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Additional
{
    public static class Sorting
    {
        public static void BubbleSorting(int[] array)
        {
            for (var partIndex = array.Length - 1; partIndex >= 0; partIndex--)
            {
                for (var j = 0; j < partIndex; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (var partIndex = array.Length - 1; partIndex >= 0; partIndex--)
            {
                var largerIndex = 0;

                for (var i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[largerIndex])
                    {
                        largerIndex = i;
                    }
                }

                (array[partIndex], array[largerIndex]) = (array[largerIndex], array[partIndex]);
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (var partIndex = 1; partIndex < array.Length; partIndex++)
            {
                var curUnsorted = array[partIndex];
                
                int i;
                for (i = partIndex; i > 0 && array[i - 1] > curUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }

                array[i] = curUnsorted;

            }
        }
    }
}
