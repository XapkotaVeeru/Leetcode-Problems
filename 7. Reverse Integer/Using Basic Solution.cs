public class Solution {
    public int Reverse(int x) {
        int sum = 0;

        while (x != 0) {
            int rem = x % 10;
            x = x / 10;

            if (sum > int.MaxValue / 10 ||
                (sum == int.MaxValue / 10 && rem > 7)) {
                return 0;
            }
            if (sum < int.MinValue / 10 ||
                (sum == int.MinValue / 10 && rem < -8)) {
                return 0;
            }

            sum = sum * 10 + rem;
        }

        return sum;
    }
}
