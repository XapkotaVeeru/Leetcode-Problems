public class Solution {
    public bool IsPerfectSquare(int num) {
        double a = 0;
        while(a*a<=num){
            if(a*a == num){
                return true;
            }
            a++;
        }
        return false;
    }
}
