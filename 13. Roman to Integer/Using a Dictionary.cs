public class Solution {
    public int RomanToInt(string s) {
        var dict = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };
        int total = 0;

        for(int i =s.Length -1; i>=0; i--){
            if (i != s.Length - 1 && dict[s[i]] < dict[s[i+1]]){
                total = total - dict[s[i]];
                continue;
            }
            total = total + dict[s[i]];
        }

        return total;
    }


}
