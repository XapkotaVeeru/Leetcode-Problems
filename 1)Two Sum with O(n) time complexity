class Solution:
    def twoSum(self, nums, target):
        seen = {}
        for i, value in enumerate(nums):
            needed = target - value
            if needed in seen:
                return [seen[needed], i]
            seen[value] = i

        
