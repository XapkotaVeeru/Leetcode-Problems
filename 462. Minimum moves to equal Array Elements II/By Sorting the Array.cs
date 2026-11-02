public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        int median = nums[nums.Length / 2];
        int count = 0;

        foreach(var item in nums){
            count = count + Math.Abs(median - item);
        }
        return count;
    }
}
