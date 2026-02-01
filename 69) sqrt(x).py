class Solution:
    def mySqrt(self, x: int) -> int:
        a = 0
        while (a + 1) * (a + 1) <= x:
            a += 1
        return a
