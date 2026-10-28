public class Solution {
    public bool IsPalindrome(int x) {
        int b = x;
        int a = 0;
        if(b<0){
            return false;
        }

        while(b >0){
            a = a*10 + b%10;
            b = b/10;
        }
        if(x == a ){
            return true;
        }
        else{
            return false;
        }
    }
}
