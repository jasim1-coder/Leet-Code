public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int total = 0;
        double avg = 0 ;
        int  l = 0 ;
        int r = k ;
        for(int i = 0 ; i < k  ; i++){
            total += nums[i];
        }
        avg = (double)total / k ;
        while(r < nums.Length ){
            total += nums[r];
            total -= nums[l];
            avg = Math.Max(avg,(double)total / k);

            r++;
            l++;

        }

        return avg;
    }
}