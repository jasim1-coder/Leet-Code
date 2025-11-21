public class Solution {
    public int Trap(int[] height) {
        int leftmax = 0, rightmax = 0, left = 0 , right = height.Length - 1 , result = 0;
        while(left < right){
        if(height[left] <= height[right]){
                leftmax = Math.Max(leftmax, height[left]);
                result += leftmax - height[left] ;
                 left++;
            }else{
                rightmax = Math.Max(rightmax, height[right]);
                result += rightmax - height[right] ;
                right--;
            }
        }
        return result;
    }
}