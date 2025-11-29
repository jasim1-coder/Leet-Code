public class Solution {
    public void NextPermutation(int[] nums) {
        
        int index = -1 ;
        for(int i = nums.Length -2 ; i>=0 ; i--){
            if(nums[i] < nums[i + 1]){
                index = i ;
                break;
            }
        }
        if(index == -1){
            int l = 0 , r = nums.Length -1;
            reverse(nums,l,r);
            return;
        }

        for(int j = nums.Length -1 ; j >= index ; j--){
            if(nums[j] > nums[index]){
                int temp = nums[j];
                nums[j] = nums[index];
                nums[index] = temp;
                break;
            }
        }

        reverse(nums,index+1,nums.Length-1);


    }
        static void reverse(int[] nums, int l, int r){
        
        while(l<r){
            int temp = nums[r];
            nums[r] = nums[l];
            nums[l] = temp;
            l++;
            r--;
            }
        }
}