class Solution(object):
    def romanToInt(self, s):
        dict={"I": 1, "V": 5, "X": 10, "L": 50, "C": 100, "D": 500, "M": 1000}
        total = 0
        for i in range (len(s)-1):
            if dict[s[i]] < dict[s[i+1]] :
                total = total - dict[s[i]]
            else:
                total = total + dict[s[i]]
        return total + dict[s[len(s)-1]]
