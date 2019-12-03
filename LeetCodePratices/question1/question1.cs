using System;
using System.Collections.Generic;

namespace LeetCodePratices
{
    /*
     * Two Sum
     *
     * Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        Example:

        Given nums = [2, 7, 11, 15], target = 9,

        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1].
     */
    public class question1
    {
        public question1()
        {
            
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            var dictNums = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictNums.ContainsKey(target - nums[i]))
                {
                    result[0] = dictNums[target - nums[i]];
                    result[1] = i;
                    break;
                }

                if (!dictNums.ContainsKey(nums[i]))
                {
                    dictNums.Add(nums[i], i);
                }
            }

            return result;

        }
    }
}
