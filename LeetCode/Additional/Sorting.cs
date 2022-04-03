using System;

namespace LeetCode.Additional
{
    public static class Sorting
    {
        /// <summary>
        /// O(N^2)
        /// Stable
        /// In-Place
        /// </summary>
        /// <param name="array"></param>
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

        /// <summary>
        /// O(N^2)
        /// Unstable
        /// In-Place
        /// </summary>
        /// <param name="array"></param>
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

        /// <summary>
        /// Worst - O(N^2), but in the best - O(N)
        /// Stable
        /// In-Place
        /// </summary>
        /// <param name="array"></param>
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

        /// <summary>
        /// O(N^3/2)
        /// Unstable
        /// In-Place
        /// </summary>
        /// <param name="array"></param>
        public static void ShellSort(int[] array)
        {
            // Shell sort gap
            for (var gap = array.Length / 2; gap >= 1; gap /= 2)
            {
                // Insertion sort
                for (var partIndex = gap; partIndex < array.Length; partIndex++)
                {
                    var curUnsorted = array[partIndex];

                    int i;
                    for (i = partIndex; i >= gap && array[i - gap] > curUnsorted; i -= gap)
                    {
                        array[i] = array[i - gap];
                    }

                    array[i] = curUnsorted;
                }
            }
        }

        /// <summary>
        /// High level merge sort for understand
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] MergeSortHighLevel(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            var partIndex = array.Length / 2;
            var a = new int[partIndex];
            var b = new int[array.Length - partIndex];
            Array.Copy(array, a, a.Length);
            Array.Copy(array, array.Length - partIndex - 1, b, 0, b.Length);

            var sortedA = MergeSortHighLevel(a);
            var sortedB = MergeSortHighLevel(b);

            int[] Merge(int[] a, int[] b)
            {
                var aIndex = 0;
                var bIndex = 0;
                var result = new int[a.Length + b.Length];

                for (var i = 0; i < result.Length; i++)
                {
                    if (aIndex >= a.Length)
                    {
                        result[i] = b[bIndex];
                        bIndex++;
                    }
                    else
                    {
                        if (bIndex >= b.Length)
                        {
                            result[i] = a[aIndex];
                            aIndex++;
                        }
                        else
                        {
                            if (a[aIndex] < b[bIndex])
                            {
                                result[i] = a[aIndex];
                                aIndex++;
                            }
                            else
                            {
                                result[i] = b[bIndex];
                                bIndex++;
                            }
                        }
                    }
                }

                return result;
            }

            return Merge(sortedA, sortedB);
        }

        /// <summary>
        /// Merge sort with auxiliary array.
        /// O(n log n)
        /// Stable
        /// Non in-place
        /// </summary>
        /// <param name="array"></param>
        public static void MergeSort(int[] array)
        {
            var aux = new int[array.Length];
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                {
                    return;
                }

                var mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (array[mid] <= array[mid + 1])
                {
                    return;
                }

                var i = low;
                var j = mid + 1;

                Array.Copy(array, low, aux, low, high - low + 1);

                for (var k = low; k <= high; k++)
                {
                    if (i > mid) array[k] = aux[j++];
                    else if (j > high) array[k] = aux[i++];
                    else if (aux[j] < aux[i]) array[k] = aux[j++];
                    else array[k] = aux[i++];
                }
            }
        }

        /// <summary>
        /// Worst - O(N^2), but in the average - O(n log n)   
        /// Unstable
        /// In-place
        /// </summary>
        /// <param name="array"></param>
        public static void QuickSort(int[] array)
        {
            Quick(0, array.Length - 1);

            void Quick(int low, int high)
            {
                if (high <= low)
                {
                    return;
                }

                var partition = Partition(low, high);
                Quick(low, partition - 1);
                Quick(partition + 1, high);
            }

            int Partition(int low, int high)
            {
                var pivot = high;
                var wall = low - 1;

                for (var currentIndex = low; currentIndex < high; currentIndex++)
                {
                    if (array[currentIndex] < array[pivot])
                    {
                        wall++;
                        (array[wall], array[currentIndex]) = (array[currentIndex], array[wall]);
                    }
                }

                wall++;
                (array[wall], array[pivot]) = (array[pivot], array[wall]);

                return wall;
            }
        }
    }
}