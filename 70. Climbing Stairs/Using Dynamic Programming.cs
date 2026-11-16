public class Solution {
    public int ClimbStairs(int n) {
        if(n == 1){
            return 1;
        }
        else if(n == 2){
            return 2;
        }
        int nminusone = 2;
        int nminustwo = 1;
        int current = 0;
        for(int i = 3; i<= n; i ++){
            current = nminusone + nminustwo;
            nminustwo = nminusone;
            nminusone = current;
        }

        return current;    
    }
}
