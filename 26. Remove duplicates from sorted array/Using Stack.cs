public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;

        Stack<int> stack = new Stack<int>();
        stack.Push(nums[0]);

        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i-1]) {
                continue;
            }
            stack.Push(nums[i]);
        }

        int k = stack.Count;

        foreach (var item in stack) {
            nums[--k] = item;
        }

        return stack.Count;
    }
}
