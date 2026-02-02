class Solution:
    def isValid(self, s: str) -> bool:
        map = {'}': '{', ')': '(', ']': '['}
        stack = []

        for char in s:
            if char in map.values():
                stack.append(char)
            elif char in map:
                if not stack or stack.pop() != map[char]:
                    return False

        return not stack
