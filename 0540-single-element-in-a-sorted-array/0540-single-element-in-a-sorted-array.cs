public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int low = 1, high = nums.Length - 2 ;
        if(high == -1)return nums[0];
        if(nums[0] != nums[1]) return nums[0];
        if(nums[high + 1] != nums[high]) return nums[high + 1];

        while(low <= high){
            int middle = (low + high) / 2;
            if(nums[middle] != nums[middle - 1] && nums[middle] != nums[middle +1]) return nums[middle];

            if((middle % 2 != 0 && nums[middle - 1] == nums[middle]) || (middle % 2 == 0 && nums[middle] == nums[middle + 1])){
                low = middle + 1;
            }else{
                high = middle  ;
            }
        }
        return -1;
    }
}