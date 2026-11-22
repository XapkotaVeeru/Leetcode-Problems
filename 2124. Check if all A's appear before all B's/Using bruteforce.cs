public class Solution {
    public bool CheckString(string s) {
        bool a = false;

        foreach (var item in s) {
            if (item == 'b') {
                a = true;
            }

            if (a && item == 'a') {
                return false;
            }
        }

        return true;
    }
}
