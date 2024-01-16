class Solution(object):
    def isPalindrome(self, x):
        x=str(x)
        y=x[::-1]
        if y == x:
            return True
        else:
            return False    
