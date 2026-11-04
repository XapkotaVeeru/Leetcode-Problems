public class Solution {
    public int LengthOfLastWord(string s) {
        var b = s.Trim();
        var spl = b.Split(' ');
        var end = spl.Length - 1;
        return spl[end].Length;
    }
}
