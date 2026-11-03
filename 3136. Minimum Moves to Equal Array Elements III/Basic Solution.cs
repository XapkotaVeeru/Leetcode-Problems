public class Solution {
    public int MinMoves(int[] nums) {
        int count = 0;
        foreach(var item in nums){
            count = count + (nums.Max() - item);
        }
        return count;
    }
}
