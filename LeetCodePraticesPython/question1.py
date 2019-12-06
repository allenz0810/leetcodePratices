"""
1. Two Sum

Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

"""
from typing import List, Dict 

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        result = []
        dictList = dict()
        for idx, val in enumerate(nums):
            if (target - val) in dictList:
                result.append(dictList[target - val])
                result.append(idx) 
                break
            else:
                dictList[val] = idx
        return result

solu = Solution()

print(solu.twoSum([2, 7, 11, 15], 9))