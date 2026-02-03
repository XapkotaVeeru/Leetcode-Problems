class Solution:
    def isTrionic(self, nums: List[int]) -> bool:
        n = len(nums)
        if n<4:
            return False
        
        i = 1

        if nums[i] <= nums[i-1]:
            return False
        
        while i < n and nums[i] > nums[i-1]:
            i = i + 1

        while i<n and nums[i] < nums[i-1]:
            i = i+1

        if i == n or nums[i] <= nums[i-1]:
            return False
        while i<n and nums[i] > nums [i-1]:
            i = i + 1

        return i == n 




