public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0;
        
        if(nums.Length == 0){
            return 0;
        }

        int max = nums.Max() + 1;

        for(int i = 0; i<nums.Length; i++){
            if(nums[i] == val){
                nums[i] = max;
                continue;
            }
            count++;
        }

        nums.Sort();
        return count;

    }
}
