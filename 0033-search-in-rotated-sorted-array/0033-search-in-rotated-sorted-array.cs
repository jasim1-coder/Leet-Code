public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0 , high = nums.Length - 1 ;
        while(low <= high){
            int middle = (low + high) / 2;
            if(nums[middle] == target) return middle;

            else{
                if(nums[low] <= nums[middle]){
                    if(nums[low] <= target && target <= nums[middle]){
                        high = middle - 1;
                    }else{
                        low = middle + 1;
                    }
                }else{
                    if(nums[middle] <= target && target <= nums[high]){
                        low = middle + 1;
                    }else{
                        high = middle -1 ;
                    }
                }
            }

        }
        return -1;
    }
}