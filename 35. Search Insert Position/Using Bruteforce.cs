public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums.Contains(target)){
            return(nums.IndexOf(target));
        }
        if(nums[nums.Length-1] < target){
            return nums.Length;
        }
        for(int i = 0; i<nums.Length; i++){
            if(nums[i]<target && nums[i+1]>target){
                return i+1;
            }
        }
        return 0;
    }
}
