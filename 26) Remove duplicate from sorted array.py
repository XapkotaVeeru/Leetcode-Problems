from typing import List

class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        seen = []
        
        for i in range(len(nums)):
            if nums[i] not in seen:
                seen.append(nums[i])

        nums[:] = seen
        return len(seen)
