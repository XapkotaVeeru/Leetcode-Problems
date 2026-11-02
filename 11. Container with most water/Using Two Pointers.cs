public class Solution {
    public int MaxArea(int[] height) {
        int front = 0;
        int back = height.Length - 1;
        int capacity = 0;
        while(front<back){
            int difference = back - front;
            int area = Math.Min(height[front], height[back])*difference;

            if(area>capacity){
                capacity = area;
            }
            if(height[front]>height[back]){
                back--;
            }
            else{
                front++;
            }          
        }
        return capacity;
    }
}
