public class Solution {
    public bool IsValid(string s) {
       Stack<char> p = new Stack<char>();
       Dictionary<char, char> pairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
       foreach (var element in s){
        if (pairs.ContainsKey(element)) {
                if (p.Count == 0 || p.Peek() != pairs[element]) {
                    return false;
                }
                p.Pop();
            }
        else{
            p.Push(element);
        }
       }
       return p.Count == 0;
    }
}
