public class Solution {
    public int LengthOfLastWord(string s) {
        var b = s.Trim();
        var spl = b.Split(' ');
        return spl[spl.Length -1].Length;
    }
}
