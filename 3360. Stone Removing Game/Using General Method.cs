public class Solution {
    public bool CanAliceWin(int n) {
        int i = 10;

        while (n - i >= 0) {
            n -= i;
            i--;

            if (i == 0) {
                return true;
            }
        }

        return !(i % 2 == 0);
    }
}
