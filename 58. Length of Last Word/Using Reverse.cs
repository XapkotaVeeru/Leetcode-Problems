public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        var spl = s.Split(' ');
        foreach(var element in spl.Reverse()){
            if(element.Length != 0){
                count = element.Length;
                break;
            }
        }
        return count;
    }
}
