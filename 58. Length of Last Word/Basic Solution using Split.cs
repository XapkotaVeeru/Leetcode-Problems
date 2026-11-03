public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        var spl = s.Split(' ');
        foreach(var element in spl){
            if(element.Length != 0){
                count = element.Length;
            }
        }
        return count;
    }
}
