public class Solution {
    public int MySqrt(int x) {
        double a = 0;
        if (x == 0){
            return 0;
        }
        while(a*a <= x){
            a++;
        }
        return (int)(a-1);    
    }
}
