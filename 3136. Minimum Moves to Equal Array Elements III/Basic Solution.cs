public class Solution {
    public int MinMoves(int[] nums) {
        int max = nums.Max();
        int count = 0;
        foreach(var item in nums){
            count = count + (max - item);
        }
        return count;
    }
}
