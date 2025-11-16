public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length ;
        for(int i = 0 ; i <= n ; i++){
            if(!nums.Contains(i)){
                return i;
            }
        }
        return -1 ;
    }
}