public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        int count = 0;
        bool valid;
        foreach(var item1 in arr1){
             valid = true;
            foreach(var item2 in arr2){
                if(Math.Abs(item2-item1)<=d){
                    valid = false;
                    break;
                }
            }
            if (valid){
                count++;
            }
        }
        return count;
    }
}
