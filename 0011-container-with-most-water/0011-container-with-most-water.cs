public class Solution {
    public int MaxArea(int[] height) {
        int l = 0 , r = height.Length - 1, result = 0 ;
        while(l < r){
            int lengths = r - l ;
            int heights = Math.Min(height[l], height[r]);
            int area = lengths * heights ;
            result = Math.Max(result , area);
            
            if(height[l] > height[r]){

            r--;
            }else{
            l++;

            }

        }
        return result;
    }
}