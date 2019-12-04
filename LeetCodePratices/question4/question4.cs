using System;
namespace LeetCodePratices
{
    public class question4
    {
        /*
         * Median of Two Sorted Arrays
         *There are two sorted arrays nums1 and nums2 of size m and n respectively.

            Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).

            You may assume nums1 and nums2 cannot be both empty.

            Example 1:

            nums1 = [1, 3]
            nums2 = [2]

            The median is 2.0

            Example 2:

            nums1 = [1, 2]
            nums2 = [3, 4]

            The median is (2 + 3)/2 = 2.5
         * 
         * 
         */
        public question4()
        {
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var result = -1.0;

            var m = nums1.Length;
            var n = nums2.Length;

            if (m < n)
            {
                result = FindMedianSortedArrays(nums2, nums1);
            }

            if (result < 0)
            { 

                if (n == 0)
                {
                    result = Convert.ToDouble(nums1[(m - 1) / 2] + nums1[m / 2]) / 2;
                }

                var left = 0;
                var right = 2 * n;
                while (left <= right)
                {
                    var mid2 = (left + right) / 2; // 1, 2_0
                    var mid1 = m + n - mid2; // 2, 2_4
                    var L1 = mid1 == 0 ? Double.MinValue : nums1[(mid1 - 1) / 2]; // 2, 1_2
                    var L2 = mid2 == 0 ? Double.MinValue : nums2[(mid2 - 1) / 2]; // 1, 3_MIN
                    var R1 = mid1 == m * 2 ? Double.MaxValue : nums1[mid1 / 2]; // 3, 2_MAX
                    var R2 = mid2 == n * 2 ? Double.MaxValue : nums2[mid2 / 2]; // 2, 4_3

                    if (L1 > R2) // 2 > 2, 1 > 4_2 > 3
                    {
                        left = mid2 + 1;
                    }
                    else if (L2 > R1) // 1 > 3, 3 > 2_MIN > MAX
                    {
                        right = mid2 - 1; // , 1
                    }
                    else
                    {
                        result = (Math.Max(L1, L2) + Math.Min(R1, R2)) / 2; // (2,1) + (3,2) = (2 + 2)/2 = 2 _ (2,MIN) + (MAX, 3) = (2 + 3) / 2 = 2.5
                        left = int.MaxValue;
                    }
                }
            }
            return result;
        }
    }
}
